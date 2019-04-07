<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblProcess = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbDateFormat = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.cmbSourceTimeZone = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbTimeZone = New System.Windows.Forms.ComboBox()
        Me.dgvProcesses = New System.Windows.Forms.DataGridView()
        Me.ColDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeZoneID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTimeZone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgvProcesses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProcess
        '
        Me.lblProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProcess.AutoSize = True
        Me.lblProcess.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcess.Location = New System.Drawing.Point(11, 423)
        Me.lblProcess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(93, 16)
        Me.lblProcess.TabIndex = 4
        Me.lblProcess.Text = "Processing..."
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.cmbDateFormat)
        Me.groupBox2.Controls.Add(Me.Label2)
        Me.groupBox2.Controls.Add(Me.Label1)
        Me.groupBox2.Controls.Add(Me.btnConvert)
        Me.groupBox2.Controls.Add(Me.cmbSourceTimeZone)
        Me.groupBox2.Controls.Add(Me.lblDate)
        Me.groupBox2.Controls.Add(Me.dtpDateTime)
        Me.groupBox2.Controls.Add(Me.btnAdd)
        Me.groupBox2.Controls.Add(Me.cmbTimeZone)
        Me.groupBox2.Controls.Add(Me.dgvProcesses)
        Me.groupBox2.Controls.Add(Me.lblProcess)
        Me.groupBox2.Location = New System.Drawing.Point(5, -2)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox2.Size = New System.Drawing.Size(775, 444)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        '
        'cmbDateFormat
        '
        Me.cmbDateFormat.DropDownHeight = 200
        Me.cmbDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDateFormat.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDateFormat.FormattingEnabled = True
        Me.cmbDateFormat.IntegralHeight = False
        Me.cmbDateFormat.Items.AddRange(New Object() {"dd-MMM-yyyy hh:mm:ss tt", "dd-MMM-yyyy HH:mm:ss", "dd-MM-yyyy hh:mm:ss tt", "dd-MM-yyyy HH:mm:ss", "MM-dd-yyyy hh:mm:ss tt", "MM-dd-yyyy HH:mm:ss", "MM-dd-yy hh:mm:ss tt", "MM-dd-yy HH:mm:ss", "dd-MMM-yyyy hh:mm:ss tt,ddd", "dd-MMM-yyyy HH:mm:ss,ddd", "dd-MM-yyyy hh:mm:ss tt,dddd", "dd-MM-yyyy HH:mm:ss,dddd"})
        Me.cmbDateFormat.Location = New System.Drawing.Point(377, 13)
        Me.cmbDateFormat.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDateFormat.Name = "cmbDateFormat"
        Me.cmbDateFormat.Size = New System.Drawing.Size(274, 22)
        Me.cmbDateFormat.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Format"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Time Zone"
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(658, 40)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(106, 26)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'cmbSourceTimeZone
        '
        Me.cmbSourceTimeZone.DropDownHeight = 300
        Me.cmbSourceTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSourceTimeZone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSourceTimeZone.FormattingEnabled = True
        Me.cmbSourceTimeZone.IntegralHeight = False
        Me.cmbSourceTimeZone.Location = New System.Drawing.Point(102, 40)
        Me.cmbSourceTimeZone.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSourceTimeZone.Name = "cmbSourceTimeZone"
        Me.cmbSourceTimeZone.Size = New System.Drawing.Size(549, 22)
        Me.cmbSourceTimeZone.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(11, 17)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(83, 14)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date && Time"
        '
        'dtpDateTime
        '
        Me.dtpDateTime.CustomFormat = "dd-MMM-yyyy hh:mm:ss tt"
        Me.dtpDateTime.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTime.Location = New System.Drawing.Point(102, 14)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(217, 22)
        Me.dtpDateTime.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(658, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 26)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbTimeZone
        '
        Me.cmbTimeZone.DropDownHeight = 300
        Me.cmbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeZone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeZone.FormattingEnabled = True
        Me.cmbTimeZone.IntegralHeight = False
        Me.cmbTimeZone.Location = New System.Drawing.Point(11, 87)
        Me.cmbTimeZone.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTimeZone.Name = "cmbTimeZone"
        Me.cmbTimeZone.Size = New System.Drawing.Size(640, 22)
        Me.cmbTimeZone.TabIndex = 4
        '
        'dgvProcesses
        '
        Me.dgvProcesses.AllowUserToAddRows = False
        Me.dgvProcesses.AllowUserToDeleteRows = False
        Me.dgvProcesses.AllowUserToOrderColumns = True
        Me.dgvProcesses.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvProcesses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProcesses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProcesses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColDelete, Me.ColID, Me.TimeZoneID, Me.ColTimeZone, Me.DateTime})
        Me.dgvProcesses.Location = New System.Drawing.Point(11, 114)
        Me.dgvProcesses.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProcesses.Name = "dgvProcesses"
        Me.dgvProcesses.ReadOnly = True
        Me.dgvProcesses.RowHeadersVisible = False
        Me.dgvProcesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProcesses.Size = New System.Drawing.Size(753, 307)
        Me.dgvProcesses.TabIndex = 6
        '
        'ColDelete
        '
        Me.ColDelete.HeaderText = ""
        Me.ColDelete.Image = Global.TimeZoneConverter.My.Resources.Resources.DeleteRed
        Me.ColDelete.Name = "ColDelete"
        Me.ColDelete.ReadOnly = True
        Me.ColDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColDelete.ToolTipText = "Delete"
        Me.ColDelete.Width = 30
        '
        'ColID
        '
        Me.ColID.HeaderText = "ID"
        Me.ColID.Name = "ColID"
        Me.ColID.ReadOnly = True
        Me.ColID.Visible = False
        '
        'TimeZoneID
        '
        Me.TimeZoneID.DataPropertyName = "TimeZoneId"
        Me.TimeZoneID.HeaderText = "Time Zone ID"
        Me.TimeZoneID.Name = "TimeZoneID"
        Me.TimeZoneID.ReadOnly = True
        Me.TimeZoneID.ToolTipText = "Time Zone ID"
        Me.TimeZoneID.Width = 180
        '
        'ColTimeZone
        '
        Me.ColTimeZone.DataPropertyName = "TimeZoneName"
        Me.ColTimeZone.HeaderText = "Time Zone"
        Me.ColTimeZone.Name = "ColTimeZone"
        Me.ColTimeZone.ReadOnly = True
        Me.ColTimeZone.ToolTipText = "Time zone display name"
        Me.ColTimeZone.Width = 320
        '
        'DateTime
        '
        Me.DateTime.DataPropertyName = "DateTime"
        Me.DateTime.HeaderText = "Date & Time"
        Me.DateTime.Name = "DateTime"
        Me.DateTime.ReadOnly = True
        Me.DateTime.ToolTipText = "Date And Time"
        Me.DateTime.Width = 190
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 447)
        Me.Controls.Add(Me.groupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Zone Converter"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.dgvProcesses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblProcess As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProcesses As System.Windows.Forms.DataGridView
    Friend WithEvents cmbTimeZone As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dtpDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents cmbSourceTimeZone As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDateFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColDelete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeZoneID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTimeZone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTime As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
