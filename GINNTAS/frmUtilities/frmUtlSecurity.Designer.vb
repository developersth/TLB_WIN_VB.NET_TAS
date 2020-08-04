<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtlSecurity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtlSecurity))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UcFooter1 = New GINNTAS.ucFooter()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UcBack1 = New GINNTAS.ucBack()
        Me.UcHeader1 = New GINNTAS.ucHeader()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.cmdReport = New System.Windows.Forms.Button()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.lblPriorityName = New System.Windows.Forms.Label()
        Me.SAVE = New System.Windows.Forms.Button()
        Me.Cancle = New System.Windows.Forms.Button()
        Me.txtTotalRecord = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcMenuProgrammer = New GINNTAS.ucMenutxtSub()
        Me.UcMenuEngineer = New GINNTAS.ucMenutxtSub()
        Me.UcMenuSSLTO = New GINNTAS.ucMenutxtSub()
        Me.UcMenuDepotOperator = New GINNTAS.ucMenutxtSub()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.UcFooter1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 733)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 35)
        Me.Panel3.TabIndex = 180
        '
        'UcFooter1
        '
        Me.UcFooter1.BackColor = System.Drawing.Color.Transparent
        Me.UcFooter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcFooter1.Location = New System.Drawing.Point(0, 0)
        Me.UcFooter1.Name = "UcFooter1"
        Me.UcFooter1.Size = New System.Drawing.Size(1022, 33)
        Me.UcFooter1.TabIndex = 1
        Me.UcFooter1.Tag = ""
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcBack1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 40)
        Me.Panel4.TabIndex = 182
        '
        'UcBack1
        '
        Me.UcBack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBack1.BackgroundImage = CType(resources.GetObject("UcBack1.BackgroundImage"), System.Drawing.Image)
        Me.UcBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcBack1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBack1.Location = New System.Drawing.Point(893, 1)
        Me.UcBack1.Name = "UcBack1"
        Me.UcBack1.Size = New System.Drawing.Size(127, 35)
        Me.UcBack1.TabIndex = 1
        '
        'UcHeader1
        '
        Me.UcHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcHeader1.Location = New System.Drawing.Point(0, 0)
        Me.UcHeader1.MenuText = "Title"
        Me.UcHeader1.Name = "UcHeader1"
        Me.UcHeader1.Size = New System.Drawing.Size(1024, 106)
        Me.UcHeader1.TabIndex = 181
        '
        'pnlFooter
        '
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.cmdReport)
        Me.pnlFooter.Controls.Add(Me.lblPriority)
        Me.pnlFooter.Controls.Add(Me.lblPriorityName)
        Me.pnlFooter.Controls.Add(Me.SAVE)
        Me.pnlFooter.Controls.Add(Me.Cancle)
        Me.pnlFooter.Controls.Add(Me.txtTotalRecord)
        Me.pnlFooter.Controls.Add(Me.label1)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 691)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1024, 42)
        Me.pnlFooter.TabIndex = 185
        '
        'cmdReport
        '
        Me.cmdReport.BackColor = System.Drawing.Color.Blue
        Me.cmdReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdReport.Location = New System.Drawing.Point(21, 4)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(131, 30)
        Me.cmdReport.TabIndex = 27
        Me.cmdReport.Text = "พิมพ์รายงาน"
        Me.cmdReport.UseVisualStyleBackColor = False
        '
        'lblPriority
        '
        Me.lblPriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPriority.Location = New System.Drawing.Point(343, 9)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(20, 24)
        Me.lblPriority.TabIndex = 26
        Me.lblPriority.Text = "0"
        Me.lblPriority.Visible = False
        '
        'lblPriorityName
        '
        Me.lblPriorityName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPriorityName.AutoSize = True
        Me.lblPriorityName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPriorityName.Location = New System.Drawing.Point(206, 7)
        Me.lblPriorityName.Name = "lblPriorityName"
        Me.lblPriorityName.Size = New System.Drawing.Size(136, 24)
        Me.lblPriorityName.TabIndex = 25
        Me.lblPriorityName.Text = "lblPriorityName"
        '
        'SAVE
        '
        Me.SAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SAVE.BackColor = System.Drawing.Color.Lime
        Me.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SAVE.Location = New System.Drawing.Point(611, 4)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(75, 29)
        Me.SAVE.TabIndex = 24
        Me.SAVE.Text = "บันทึก"
        Me.SAVE.UseVisualStyleBackColor = False
        Me.SAVE.Visible = False
        '
        'Cancle
        '
        Me.Cancle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cancle.Location = New System.Drawing.Point(698, 3)
        Me.Cancle.Name = "Cancle"
        Me.Cancle.Size = New System.Drawing.Size(75, 29)
        Me.Cancle.TabIndex = 23
        Me.Cancle.Text = "ยกเลิก"
        Me.Cancle.UseVisualStyleBackColor = False
        Me.Cancle.Visible = False
        '
        'txtTotalRecord
        '
        Me.txtTotalRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRecord.Location = New System.Drawing.Point(911, 3)
        Me.txtTotalRecord.Name = "txtTotalRecord"
        Me.txtTotalRecord.ReadOnly = True
        Me.txtTotalRecord.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalRecord.TabIndex = 5
        Me.txtTotalRecord.Text = "0"
        Me.txtTotalRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(783, 6)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 20)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Total Record :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.82422!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.17578!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 146)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 552.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1024, 545)
        Me.TableLayoutPanel1.TabIndex = 186
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcMenuProgrammer)
        Me.Panel1.Controls.Add(Me.UcMenuEngineer)
        Me.Panel1.Controls.Add(Me.UcMenuSSLTO)
        Me.Panel1.Controls.Add(Me.UcMenuDepotOperator)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 539)
        Me.Panel1.TabIndex = 0
        '
        'UcMenuProgrammer
        '
        Me.UcMenuProgrammer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuProgrammer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuProgrammer.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuProgrammer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuProgrammer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuProgrammer.Enabled = False
        Me.UcMenuProgrammer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuProgrammer.Location = New System.Drawing.Point(19, 175)
        Me.UcMenuProgrammer.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuProgrammer.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuProgrammer.MenuCorners = 6
        Me.UcMenuProgrammer.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuProgrammer.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuProgrammer.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenuProgrammer.MenuIcon = Nothing
        Me.UcMenuProgrammer.MenuIconSize = New System.Drawing.Size(15, 19)
        Me.UcMenuProgrammer.MenuScreenID = CType(0, Long)
        Me.UcMenuProgrammer.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuProgrammer.MenuText = "Programmer"
        Me.UcMenuProgrammer.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuProgrammer.MenuTextMargin = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.UcMenuProgrammer.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuProgrammer.MenuTextShadowShow = False
        Me.UcMenuProgrammer.Name = "UcMenuProgrammer"
        Me.UcMenuProgrammer.Size = New System.Drawing.Size(144, 38)
        Me.UcMenuProgrammer.TabIndex = 53
        '
        'UcMenuEngineer
        '
        Me.UcMenuEngineer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuEngineer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuEngineer.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuEngineer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuEngineer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuEngineer.Enabled = False
        Me.UcMenuEngineer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuEngineer.Location = New System.Drawing.Point(18, 124)
        Me.UcMenuEngineer.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuEngineer.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuEngineer.MenuCorners = 6
        Me.UcMenuEngineer.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuEngineer.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuEngineer.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenuEngineer.MenuIcon = Nothing
        Me.UcMenuEngineer.MenuIconSize = New System.Drawing.Size(15, 19)
        Me.UcMenuEngineer.MenuScreenID = CType(0, Long)
        Me.UcMenuEngineer.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuEngineer.MenuText = "Engineer"
        Me.UcMenuEngineer.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuEngineer.MenuTextMargin = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.UcMenuEngineer.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuEngineer.MenuTextShadowShow = False
        Me.UcMenuEngineer.Name = "UcMenuEngineer"
        Me.UcMenuEngineer.Size = New System.Drawing.Size(144, 38)
        Me.UcMenuEngineer.TabIndex = 52
        '
        'UcMenuSSLTO
        '
        Me.UcMenuSSLTO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuSSLTO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuSSLTO.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuSSLTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuSSLTO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuSSLTO.Enabled = False
        Me.UcMenuSSLTO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuSSLTO.Location = New System.Drawing.Point(19, 73)
        Me.UcMenuSSLTO.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuSSLTO.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuSSLTO.MenuCorners = 6
        Me.UcMenuSSLTO.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuSSLTO.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuSSLTO.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenuSSLTO.MenuIcon = Nothing
        Me.UcMenuSSLTO.MenuIconSize = New System.Drawing.Size(15, 19)
        Me.UcMenuSSLTO.MenuScreenID = CType(0, Long)
        Me.UcMenuSSLTO.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuSSLTO.MenuText = "SS/LTO"
        Me.UcMenuSSLTO.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuSSLTO.MenuTextMargin = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.UcMenuSSLTO.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuSSLTO.MenuTextShadowShow = False
        Me.UcMenuSSLTO.Name = "UcMenuSSLTO"
        Me.UcMenuSSLTO.Size = New System.Drawing.Size(144, 38)
        Me.UcMenuSSLTO.TabIndex = 51
        '
        'UcMenuDepotOperator
        '
        Me.UcMenuDepotOperator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMenuDepotOperator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcMenuDepotOperator.BackColor = System.Drawing.Color.Transparent
        Me.UcMenuDepotOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UcMenuDepotOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuDepotOperator.Enabled = False
        Me.UcMenuDepotOperator.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcMenuDepotOperator.Location = New System.Drawing.Point(22, 21)
        Me.UcMenuDepotOperator.MaximumSize = New System.Drawing.Size(550, 91)
        Me.UcMenuDepotOperator.MenuAuthorizeID = CType(0, Long)
        Me.UcMenuDepotOperator.MenuCorners = 6
        Me.UcMenuDepotOperator.MenuCursor = System.Windows.Forms.Cursors.Hand
        Me.UcMenuDepotOperator.MenuFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcMenuDepotOperator.MenuForeColor = System.Drawing.SystemColors.ControlText
        Me.UcMenuDepotOperator.MenuIcon = Nothing
        Me.UcMenuDepotOperator.MenuIconSize = New System.Drawing.Size(15, 19)
        Me.UcMenuDepotOperator.MenuScreenID = CType(0, Long)
        Me.UcMenuDepotOperator.MenuShape = CButtonLib.CButton.eShape.Rectangle
        Me.UcMenuDepotOperator.MenuText = "Depot Operator"
        Me.UcMenuDepotOperator.MenuTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcMenuDepotOperator.MenuTextMargin = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.UcMenuDepotOperator.MenuTextShadowColor = System.Drawing.Color.Snow
        Me.UcMenuDepotOperator.MenuTextShadowShow = False
        Me.UcMenuDepotOperator.Name = "UcMenuDepotOperator"
        Me.UcMenuDepotOperator.Size = New System.Drawing.Size(144, 38)
        Me.UcMenuDepotOperator.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(206, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 539)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(813, 537)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Screen No."
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 123
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sub"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 66
        '
        'Column3
        '
        Me.Column3.HeaderText = "Main Menu "
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 126
        '
        'Column4
        '
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Permit"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 85
        '
        'Column6
        '
        Me.Column6.HeaderText = "Confirm PW"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 109
        '
        'frmUtlSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UcHeader1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmUtlSecurity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfigBaseProduct_main"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UcFooter1 As GINNTAS.ucFooter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcHeader1 As GINNTAS.ucHeader
    Private WithEvents pnlFooter As System.Windows.Forms.Panel
    Private WithEvents txtTotalRecord As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcMenuProgrammer As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuEngineer As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuSSLTO As GINNTAS.ucMenutxtSub
    Friend WithEvents UcMenuDepotOperator As GINNTAS.ucMenutxtSub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmdReport As System.Windows.Forms.Button
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents lblPriorityName As System.Windows.Forms.Label
    Friend WithEvents SAVE As System.Windows.Forms.Button
    Friend WithEvents Cancle As System.Windows.Forms.Button
    Friend WithEvents UcBack1 As GINNTAS.ucBack
End Class
