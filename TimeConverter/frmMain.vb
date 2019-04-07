Imports System.IO

Public Class frmMain

#Region "Form Related Code"
    Private m_strDateTimeFormat As String = "dd-MMM-yyyy hh:mm:ss tt"

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'My.Settings.Item("TimeZone") = cmbSourceTimeZone.SelectedValue
            'My.Settings.Item("DateTimeFormat") = cmbDateFormat.Text
            'My.Settings.Save()

            My.Settings.TimeZone = cmbSourceTimeZone.SelectedValue
            My.Settings.DateTimeFormat = cmbDateFormat.Text
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = My.Resources.world_clock
            cmbDateFormat.SelectedIndex = 0
            pLoadSystemTimeZone()
            pLoadTimeZones()

            Dim sSavedTimeFormat As String = My.Settings.DateTimeFormat.ToString()
            Dim sSavedTimeZone As String = My.Settings.TimeZone.ToString()

            If String.IsNullOrEmpty(sSavedTimeFormat) = False Then cmbDateFormat.Text = sSavedTimeFormat
            If String.IsNullOrEmpty(sSavedTimeZone) = False Then cmbSourceTimeZone.SelectedValue = sSavedTimeZone

            pConvertTime()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If cmbTimeZone.SelectedIndex <> -1 Then
                Dim dr() As DataRow = m_dsTimeZones.Tables(0).Select("TimeZoneID='" & cmbTimeZone.SelectedValue & "'")
                If dr.Length > 0 Then
                    SetProcessLabel("TimeZone already exist")
                    Exit Sub
                End If
                pAddNewTimeZone(cmbTimeZone.SelectedValue, cmbTimeZone.Text)

                pSaveTimeZone()
                SetProcessLabel("Completed")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Try
            pConvertTime()
            SetProcessLabel("Completed")
        Catch ex As Exception
            SetProcessLabel("Error : " & ex.Message)
            MessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub dgvProcesses_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProcesses.CellClick
        Try
            If e.RowIndex <> -1 AndAlso dgvProcesses.Columns(e.ColumnIndex).Name = "ColDelete" Then

                Dim dr() As DataRow = m_dsTimeZones.Tables(0).Select("TimeZoneID='" & dgvProcesses.Rows(e.RowIndex).Cells("TimeZoneId").Value & "'")
                If dr.Length > 0 Then
                    dr(0).Delete()
                End If

                pSaveTimeZone()
                SetProcessLabel("Completed")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cmbDateFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDateFormat.SelectedIndexChanged
        Try
            If cmbDateFormat.Text IsNot Nothing AndAlso String.IsNullOrEmpty(cmbDateFormat.Text) = False Then
                m_strDateTimeFormat = cmbDateFormat.Text
                dtpDateTime.CustomFormat = m_strDateTimeFormat
                pConvertTime()
                SetProcessLabel("Completed")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region

#Region "Function and Procedures"
    Private m_dsTimeZones As New DataSet
    Dim m_DataFilePath As String = Path.Combine(Application.StartupPath, My.Application.Info.AssemblyName & "_Data.xml")

    Private Sub pLoadTimeZones()
        Try
            SetProcessLabel("Fetching process list")
            If m_dsTimeZones Is Nothing Then m_dsTimeZones = New DataSet

            If File.Exists(m_DataFilePath) Then
                m_dsTimeZones = New DataSet
                m_dsTimeZones.ReadXml(m_DataFilePath, XmlReadMode.Auto)
            Else
                Dim dtTimeZone As New DataTable("TimeZones")
                dtTimeZone.Columns.Add("ID", GetType(System.Int64))
                dtTimeZone.Columns.Add("TimeZoneId", GetType(System.String))
                dtTimeZone.Columns.Add("TimeZoneName", GetType(System.String))
                dtTimeZone.Columns.Add("DateTime", GetType(System.String))
                m_dsTimeZones.Tables.Add(dtTimeZone)
            End If

            If m_dsTimeZones.Tables("TimeZones").Rows.Count = 0 Then
                Dim tz As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(TimeZone.CurrentTimeZone.StandardName)
                pAddNewTimeZone(tz.Id, tz.DisplayName & " (" & tz.Id & ")")
            End If

            dgvProcesses.AutoGenerateColumns = False
            dgvProcesses.DataSource = m_dsTimeZones.Tables("TimeZones")
            'dgvProcesses.Refresh()

            pConvertTime()
        Catch ex As Exception
            Throw ex
        Finally
            SetProcessLabel("")
        End Try
    End Sub

    Private Sub pLoadSystemTimeZone()
        Try
            SetProcessLabel("Loading system time zones")
            Dim dtTimeZone As New DataTable
            dtTimeZone.Columns.Add("TimeZoneId", GetType(System.String))
            dtTimeZone.Columns.Add("TimeZoneName", GetType(System.String))

            For Each tz As TimeZoneInfo In TimeZoneInfo.GetSystemTimeZones()
                Dim dr As DataRow = dtTimeZone.NewRow
                dr("TimeZoneID") = tz.Id
                dr("TimeZoneName") = tz.DisplayName & " (" & tz.Id & ")"
                dtTimeZone.Rows.Add(dr)
            Next

            cmbTimeZone.DataSource = dtTimeZone.Copy
            cmbTimeZone.ValueMember = "TimeZoneId"
            cmbTimeZone.DisplayMember = "TimeZoneName"

            cmbSourceTimeZone.DataSource = dtTimeZone.Copy
            cmbSourceTimeZone.ValueMember = "TimeZoneId"
            cmbSourceTimeZone.DisplayMember = "TimeZoneName"


            cmbTimeZone.SelectedValue = TimeZone.CurrentTimeZone.StandardName
            cmbSourceTimeZone.SelectedValue = TimeZone.CurrentTimeZone.StandardName

        Catch ex As Exception
            Throw ex
        Finally
            SetProcessLabel("")
        End Try
    End Sub

    Private Sub SetProcessLabel(ByVal Msg As String)
        Try
            lblProcess.Text = Msg
            Application.DoEvents()
        Catch ex As Exception
            'Throw ex
        End Try
    End Sub

    Private Sub pAddNewTimeZone(ByVal TimeZoneId As String, ByVal TimeZoneName As String)
        Try
            SetProcessLabel("Adding New time zone")

            With m_dsTimeZones.Tables("TimeZones")
                Dim iNextId = .Compute("Max(Id)", "")
                If IsDBNull(iNextId) Then
                    iNextId = 1
                Else
                    iNextId += 1
                End If

                Dim dr As DataRow = .NewRow
                dr("ID") = iNextId
                dr("TimeZoneId") = TimeZoneId
                dr("TimeZoneName") = TimeZoneName

                Dim TimeZoneDatetime As DateTime = fnConvertTimeByTimeZone(TimeZoneId)
                If TimeZoneDatetime <> Date.MinValue Then
                    dr("DateTime") = TimeZoneDatetime.ToString(m_strDateTimeFormat)
                    'dr("DateTime") = TimeZoneDatetime.ToString("dd-MMM-yyyy hh:mm:ss tt")
                End If
                .Rows.Add(dr)
                SetProcessLabel("New timezone added successfully")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub pSaveTimeZone()
        Try
            SetProcessLabel("Save timezones")
            If m_dsTimeZones IsNot Nothing AndAlso m_dsTimeZones.Tables.Count > 0 Then
                m_dsTimeZones.WriteXml(m_DataFilePath, XmlWriteMode.WriteSchema)

                pLoadTimeZones()
            End If
            SetProcessLabel("Save timezones successfully")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub pConvertTime()
        Try
            For Each dr As DataGridViewRow In dgvProcesses.Rows
                Dim TimeZoneDatetime As DateTime = fnConvertTimeByTimeZone(dr.Cells("TimeZoneID").Value)
                If TimeZoneDatetime = Date.MinValue Then
                    dr.Cells("DateTime").Value = Nothing
                Else
                    dr.Cells("DateTime").Value = TimeZoneDatetime.ToString(m_strDateTimeFormat)
                    'dr.Cells("DateTime").Value = TimeZoneDatetime.ToString("dd-MMM-yyyy hh:mm:ss tt")
                End If
                'dr.Cells("DateTime").Value = fnConvertTimeByTimeZone(dr.Cells("TimeZoneID").Value).ToString("dd-MMM-yyyy hh:mm:ss tt")
            Next
            dgvProcesses.Refresh()
            SetProcessLabel("Completed")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fnConvertTimeByTimeZone(ByVal TimeZoneId As String) As DateTime
        Try
            SetProcessLabel("Converting time for " & TimeZoneId)
            Dim sourceTimeZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(cmbSourceTimeZone.SelectedValue)
            Dim DestinationTimeZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneId)
            Dim dtmDateTime As DateTime = dtpDateTime.Value
            dtmDateTime = System.DateTime.SpecifyKind(dtmDateTime, DateTimeKind.Unspecified)
            If sourceTimeZone.IsInvalidTime(dtmDateTime) Then
                Throw New Exception("The time " & dtmDateTime.ToString("dd-MMM-yyyy hh:mm:ss tt") & " does not exist in " & cmbSourceTimeZone.SelectedValue & ".It could be because Daylight Saving Time skipped one hour, or a time zone change. Please try with an hour earlier or later.")
                dtmDateTime = dtmDateTime.AddHours(1)
            End If
            Dim result As DateTime = TimeZoneInfo.ConvertTime(dtmDateTime, sourceTimeZone, DestinationTimeZone)
            Return result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
