<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BatchGUI
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BatchGUI))
        Me.CheckBoxDub = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSubs = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMkv = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMks = New System.Windows.Forms.CheckBox()
        Me.EpFrom = New System.Windows.Forms.TextBox()
        Me.CheckBoxAlt = New System.Windows.Forms.CheckBox()
        Me.SeriesId = New System.Windows.Forms.TextBox()
        Me.LabelSeriesID = New System.Windows.Forms.Label()
        Me.LabelEpFrom = New System.Windows.Forms.Label()
        Me.LabelEpTo = New System.Windows.Forms.Label()
        Me.LabelLayers = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxShowOveride = New System.Windows.Forms.TextBox()
        Me.TextBoxSuffixOveride = New System.Windows.Forms.TextBox()
        Me.TextBoxReleaseGroup = New System.Windows.Forms.TextBox()
        Me.LabelSuffixOveride = New System.Windows.Forms.Label()
        Me.LabelShowTitleOveride = New System.Windows.Forms.Label()
        Me.LabelReleaseGroup = New System.Windows.Forms.Label()
        Me.ButtonCreateBatch = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxProxyAddr = New System.Windows.Forms.TextBox()
        Me.LabelProxyAddr = New System.Windows.Forms.Label()
        Me.RadioProxySocks = New System.Windows.Forms.RadioButton()
        Me.RadioProxyHttp = New System.Windows.Forms.RadioButton()
        Me.RadioProxyNone = New System.Windows.Forms.RadioButton()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.ButtonCreateBat = New System.Windows.Forms.Button()
        Me.EpTo = New System.Windows.Forms.TextBox()
        Me.Layers = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBoxDub
        '
        Me.CheckBoxDub.AutoSize = True
        Me.CheckBoxDub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxDub.Location = New System.Drawing.Point(12, 298)
        Me.CheckBoxDub.Name = "CheckBoxDub"
        Me.CheckBoxDub.Size = New System.Drawing.Size(145, 19)
        Me.CheckBoxDub.TabIndex = 0
        Me.CheckBoxDub.Text = "Japanese Dub (--sub)"
        Me.CheckBoxDub.UseVisualStyleBackColor = True
        '
        'CheckBoxSubs
        '
        Me.CheckBoxSubs.AutoSize = True
        Me.CheckBoxSubs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSubs.Location = New System.Drawing.Point(12, 321)
        Me.CheckBoxSubs.Name = "CheckBoxSubs"
        Me.CheckBoxSubs.Size = New System.Drawing.Size(183, 19)
        Me.CheckBoxSubs.TabIndex = 1
        Me.CheckBoxSubs.Text = "Skip Subs for Dub (--nosubs)"
        Me.CheckBoxSubs.UseVisualStyleBackColor = True
        '
        'CheckBoxMkv
        '
        Me.CheckBoxMkv.AutoSize = True
        Me.CheckBoxMkv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxMkv.Location = New System.Drawing.Point(12, 344)
        Me.CheckBoxMkv.Name = "CheckBoxMkv"
        Me.CheckBoxMkv.Size = New System.Drawing.Size(143, 19)
        Me.CheckBoxMkv.TabIndex = 2
        Me.CheckBoxMkv.Text = "Mux into MKV (--mkv)"
        Me.CheckBoxMkv.UseVisualStyleBackColor = True
        '
        'CheckBoxMks
        '
        Me.CheckBoxMks.AutoSize = True
        Me.CheckBoxMks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxMks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CheckBoxMks.Location = New System.Drawing.Point(12, 367)
        Me.CheckBoxMks.Name = "CheckBoxMks"
        Me.CheckBoxMks.Size = New System.Drawing.Size(205, 19)
        Me.CheckBoxMks.TabIndex = 3
        Me.CheckBoxMks.Text = "Add Subs to MKV or MP4 (--mks)"
        Me.CheckBoxMks.UseVisualStyleBackColor = True
        '
        'EpFrom
        '
        Me.EpFrom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EpFrom.Location = New System.Drawing.Point(194, 65)
        Me.EpFrom.Name = "EpFrom"
        Me.EpFrom.Size = New System.Drawing.Size(165, 35)
        Me.EpFrom.TabIndex = 4
        '
        'CheckBoxAlt
        '
        Me.CheckBoxAlt.AutoSize = True
        Me.CheckBoxAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAlt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CheckBoxAlt.Location = New System.Drawing.Point(5, 109)
        Me.CheckBoxAlt.Name = "CheckBoxAlt"
        Me.CheckBoxAlt.Size = New System.Drawing.Size(214, 19)
        Me.CheckBoxAlt.TabIndex = 6
        Me.CheckBoxAlt.Text = "Alternative Listing if Available (--alt)"
        Me.CheckBoxAlt.UseVisualStyleBackColor = True
        '
        'SeriesId
        '
        Me.SeriesId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SeriesId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeriesId.Location = New System.Drawing.Point(194, 24)
        Me.SeriesId.Name = "SeriesId"
        Me.SeriesId.Size = New System.Drawing.Size(165, 35)
        Me.SeriesId.TabIndex = 6
        '
        'LabelSeriesID
        '
        Me.LabelSeriesID.AutoSize = True
        Me.LabelSeriesID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeriesID.Location = New System.Drawing.Point(70, 27)
        Me.LabelSeriesID.Name = "LabelSeriesID"
        Me.LabelSeriesID.Size = New System.Drawing.Size(118, 29)
        Me.LabelSeriesID.TabIndex = 9
        Me.LabelSeriesID.Text = "Series ID:"
        Me.LabelSeriesID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEpFrom
        '
        Me.LabelEpFrom.AutoSize = True
        Me.LabelEpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEpFrom.Location = New System.Drawing.Point(16, 68)
        Me.LabelEpFrom.Name = "LabelEpFrom"
        Me.LabelEpFrom.Size = New System.Drawing.Size(172, 29)
        Me.LabelEpFrom.TabIndex = 10
        Me.LabelEpFrom.Text = "Episode From:"
        Me.LabelEpFrom.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelEpTo
        '
        Me.LabelEpTo.AutoSize = True
        Me.LabelEpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEpTo.Location = New System.Drawing.Point(43, 109)
        Me.LabelEpTo.Name = "LabelEpTo"
        Me.LabelEpTo.Size = New System.Drawing.Size(145, 29)
        Me.LabelEpTo.TabIndex = 11
        Me.LabelEpTo.Text = "Episode To:"
        Me.LabelEpTo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelLayers
        '
        Me.LabelLayers.AutoSize = True
        Me.LabelLayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLayers.Location = New System.Drawing.Point(110, 150)
        Me.LabelLayers.Name = "LabelLayers"
        Me.LabelLayers.Size = New System.Drawing.Size(78, 29)
        Me.LabelLayers.TabIndex = 12
        Me.LabelLayers.Text = "Layer:"
        Me.LabelLayers.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Layers)
        Me.GroupBox1.Controls.Add(Me.EpTo)
        Me.GroupBox1.Controls.Add(Me.LabelLayers)
        Me.GroupBox1.Controls.Add(Me.LabelSeriesID)
        Me.GroupBox1.Controls.Add(Me.LabelEpTo)
        Me.GroupBox1.Controls.Add(Me.EpFrom)
        Me.GroupBox1.Controls.Add(Me.LabelEpFrom)
        Me.GroupBox1.Controls.Add(Me.SeriesId)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 205)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Settings REQUIRED"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxAlt)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 131)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toggle Options"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxShowOveride)
        Me.GroupBox3.Controls.Add(Me.TextBoxSuffixOveride)
        Me.GroupBox3.Controls.Add(Me.TextBoxReleaseGroup)
        Me.GroupBox3.Controls.Add(Me.LabelSuffixOveride)
        Me.GroupBox3.Controls.Add(Me.LabelShowTitleOveride)
        Me.GroupBox3.Controls.Add(Me.LabelReleaseGroup)
        Me.GroupBox3.Location = New System.Drawing.Point(249, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 131)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extra Settings"
        '
        'TextBoxShowOveride
        '
        Me.TextBoxShowOveride.Location = New System.Drawing.Point(152, 59)
        Me.TextBoxShowOveride.Name = "TextBoxShowOveride"
        Me.TextBoxShowOveride.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxShowOveride.TabIndex = 7
        '
        'TextBoxSuffixOveride
        '
        Me.TextBoxSuffixOveride.Location = New System.Drawing.Point(152, 94)
        Me.TextBoxSuffixOveride.Name = "TextBoxSuffixOveride"
        Me.TextBoxSuffixOveride.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSuffixOveride.TabIndex = 6
        '
        'TextBoxReleaseGroup
        '
        Me.TextBoxReleaseGroup.Location = New System.Drawing.Point(152, 24)
        Me.TextBoxReleaseGroup.Name = "TextBoxReleaseGroup"
        Me.TextBoxReleaseGroup.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxReleaseGroup.TabIndex = 4
        '
        'LabelSuffixOveride
        '
        Me.LabelSuffixOveride.AutoSize = True
        Me.LabelSuffixOveride.Location = New System.Drawing.Point(74, 97)
        Me.LabelSuffixOveride.Name = "LabelSuffixOveride"
        Me.LabelSuffixOveride.Size = New System.Drawing.Size(76, 13)
        Me.LabelSuffixOveride.TabIndex = 3
        Me.LabelSuffixOveride.Text = "Suffix Overide:"
        '
        'LabelShowTitleOveride
        '
        Me.LabelShowTitleOveride.AutoSize = True
        Me.LabelShowTitleOveride.Location = New System.Drawing.Point(50, 62)
        Me.LabelShowTitleOveride.Name = "LabelShowTitleOveride"
        Me.LabelShowTitleOveride.Size = New System.Drawing.Size(100, 13)
        Me.LabelShowTitleOveride.TabIndex = 1
        Me.LabelShowTitleOveride.Text = "Show Title Overide:"
        '
        'LabelReleaseGroup
        '
        Me.LabelReleaseGroup.AutoSize = True
        Me.LabelReleaseGroup.Location = New System.Drawing.Point(69, 27)
        Me.LabelReleaseGroup.Name = "LabelReleaseGroup"
        Me.LabelReleaseGroup.Size = New System.Drawing.Size(81, 13)
        Me.LabelReleaseGroup.TabIndex = 0
        Me.LabelReleaseGroup.Text = "Release Group:"
        '
        'ButtonCreateBatch
        '
        Me.ButtonCreateBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreateBatch.Location = New System.Drawing.Point(55, 430)
        Me.ButtonCreateBatch.Name = "ButtonCreateBatch"
        Me.ButtonCreateBatch.Size = New System.Drawing.Size(177, 46)
        Me.ButtonCreateBatch.TabIndex = 0
        Me.ButtonCreateBatch.Text = "Generate Batch"
        Me.ButtonCreateBatch.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxProxyAddr)
        Me.GroupBox4.Controls.Add(Me.LabelProxyAddr)
        Me.GroupBox4.Controls.Add(Me.RadioProxySocks)
        Me.GroupBox4.Controls.Add(Me.RadioProxyHttp)
        Me.GroupBox4.Controls.Add(Me.RadioProxyNone)
        Me.GroupBox4.Location = New System.Drawing.Point(413, 58)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(135, 205)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proxy Settings"
        '
        'TextBoxProxyAddr
        '
        Me.TextBoxProxyAddr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxProxyAddr.Location = New System.Drawing.Point(18, 149)
        Me.TextBoxProxyAddr.Name = "TextBoxProxyAddr"
        Me.TextBoxProxyAddr.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxProxyAddr.TabIndex = 4
        '
        'LabelProxyAddr
        '
        Me.LabelProxyAddr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelProxyAddr.AutoSize = True
        Me.LabelProxyAddr.Location = New System.Drawing.Point(31, 132)
        Me.LabelProxyAddr.Name = "LabelProxyAddr"
        Me.LabelProxyAddr.Size = New System.Drawing.Size(74, 13)
        Me.LabelProxyAddr.TabIndex = 3
        Me.LabelProxyAddr.Text = "Proxy Address"
        Me.LabelProxyAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioProxySocks
        '
        Me.RadioProxySocks.AutoSize = True
        Me.RadioProxySocks.Location = New System.Drawing.Point(43, 69)
        Me.RadioProxySocks.Name = "RadioProxySocks"
        Me.RadioProxySocks.Size = New System.Drawing.Size(53, 17)
        Me.RadioProxySocks.TabIndex = 2
        Me.RadioProxySocks.Text = "socks"
        Me.RadioProxySocks.UseVisualStyleBackColor = True
        '
        'RadioProxyHttp
        '
        Me.RadioProxyHttp.AutoSize = True
        Me.RadioProxyHttp.Location = New System.Drawing.Point(43, 88)
        Me.RadioProxyHttp.Name = "RadioProxyHttp"
        Me.RadioProxyHttp.Size = New System.Drawing.Size(54, 17)
        Me.RadioProxyHttp.TabIndex = 1
        Me.RadioProxyHttp.Text = "http(s)"
        Me.RadioProxyHttp.UseVisualStyleBackColor = True
        '
        'RadioProxyNone
        '
        Me.RadioProxyNone.AutoSize = True
        Me.RadioProxyNone.Checked = True
        Me.RadioProxyNone.Location = New System.Drawing.Point(43, 51)
        Me.RadioProxyNone.Name = "RadioProxyNone"
        Me.RadioProxyNone.Size = New System.Drawing.Size(51, 17)
        Me.RadioProxyNone.TabIndex = 0
        Me.RadioProxyNone.TabStop = True
        Me.RadioProxyNone.Text = "None"
        Me.RadioProxyNone.UseVisualStyleBackColor = True
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Location = New System.Drawing.Point(15, 487)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.ReadOnly = True
        Me.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxOutput.Size = New System.Drawing.Size(533, 132)
        Me.TextBoxOutput.TabIndex = 17
        '
        'ButtonCreateBat
        '
        Me.ButtonCreateBat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreateBat.Location = New System.Drawing.Point(324, 430)
        Me.ButtonCreateBat.Name = "ButtonCreateBat"
        Me.ButtonCreateBat.Size = New System.Drawing.Size(177, 46)
        Me.ButtonCreateBat.TabIndex = 18
        Me.ButtonCreateBat.Text = "Save as .bat"
        Me.ButtonCreateBat.UseVisualStyleBackColor = True
        '
        'EpTo
        '
        Me.EpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EpTo.Location = New System.Drawing.Point(194, 106)
        Me.EpTo.Name = "EpTo"
        Me.EpTo.Size = New System.Drawing.Size(165, 35)
        Me.EpTo.TabIndex = 14
        '
        'Layers
        '
        Me.Layers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Layers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Layers.FormattingEnabled = True
        Me.Layers.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Layers.Location = New System.Drawing.Point(194, 148)
        Me.Layers.Name = "Layers"
        Me.Layers.Size = New System.Drawing.Size(165, 37)
        Me.Layers.TabIndex = 15
        '
        'BatchGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 627)
        Me.Controls.Add(Me.ButtonCreateBat)
        Me.Controls.Add(Me.TextBoxOutput)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ButtonCreateBatch)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CheckBoxMks)
        Me.Controls.Add(Me.CheckBoxMkv)
        Me.Controls.Add(Me.CheckBoxSubs)
        Me.Controls.Add(Me.CheckBoxDub)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BatchGUI"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Funimation Downloader NX Batch GUI"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxDub As CheckBox
    Friend WithEvents CheckBoxSubs As CheckBox
    Friend WithEvents CheckBoxMkv As CheckBox
    Friend WithEvents CheckBoxMks As CheckBox
    Friend WithEvents EpFrom As TextBox
    Friend WithEvents CheckBoxAlt As CheckBox
    Friend WithEvents SeriesId As TextBox
    Friend WithEvents LabelSeriesID As Label
    Friend WithEvents LabelEpFrom As Label
    Friend WithEvents LabelEpTo As Label
    Friend WithEvents LabelLayers As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelSuffixOveride As Label
    Friend WithEvents LabelShowTitleOveride As Label
    Friend WithEvents LabelReleaseGroup As Label
    Friend WithEvents ButtonCreateBatch As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBoxProxyAddr As TextBox
    Friend WithEvents LabelProxyAddr As Label
    Friend WithEvents RadioProxySocks As RadioButton
    Friend WithEvents RadioProxyHttp As RadioButton
    Friend WithEvents RadioProxyNone As RadioButton
    Friend WithEvents TextBoxShowOveride As TextBox
    Friend WithEvents TextBoxSuffixOveride As TextBox
    Friend WithEvents TextBoxReleaseGroup As TextBox
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents ButtonCreateBat As Button
    Friend WithEvents Layers As ComboBox
    Friend WithEvents EpTo As TextBox
End Class
