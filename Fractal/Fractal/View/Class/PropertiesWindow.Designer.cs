namespace Fractal.View.Class
{
    partial class PropertiesWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.staticColorsContainerPanel = new System.Windows.Forms.Panel();
            this.baseLabel = new System.Windows.Forms.Label();
            this.fractalColorLabel = new System.Windows.Forms.Label();
            this.baseColorPreviewPanel = new System.Windows.Forms.Panel();
            this.fractalColorPreviewPanel = new System.Windows.Forms.Panel();
            this.colorsFillContainerPanel = new System.Windows.Forms.Panel();
            this.greenStartvScrollBar = new System.Windows.Forms.VScrollBar();
            this.blueStartEndPreviewPanel = new System.Windows.Forms.Panel();
            this.redStartvScrollBar = new System.Windows.Forms.VScrollBar();
            this.blueEndvScrollBar = new System.Windows.Forms.VScrollBar();
            this.redEndvScrollBar = new System.Windows.Forms.VScrollBar();
            this.blueStartvScrollBar = new System.Windows.Forms.VScrollBar();
            this.redStartEndPreviewPanel = new System.Windows.Forms.Panel();
            this.greenStartEndPreviewPanel = new System.Windows.Forms.Panel();
            this.greenEndvScrollBar = new System.Windows.Forms.VScrollBar();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.imaginaryConst = new System.Windows.Forms.Label();
            this.realConstLabel = new System.Windows.Forms.Label();
            this.imaginaryConstTextBox = new System.Windows.Forms.TextBox();
            this.realConstTextBox = new System.Windows.Forms.TextBox();
            this.singleIterationMode = new System.Windows.Forms.CheckBox();
            this.renderButton = new System.Windows.Forms.Button();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.iterationshScrollBar = new System.Windows.Forms.HScrollBar();
            this.sideLenght = new System.Windows.Forms.Label();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.startPositionLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.sideLenghtTextBox = new System.Windows.Forms.TextBox();
            this.imageHeightTextBox = new System.Windows.Forms.TextBox();
            this.imageWidthTextBox = new System.Windows.Forms.TextBox();
            this.startPositionTextBox = new System.Windows.Forms.TextBox();
            this.imageSaveGroupBox = new System.Windows.Forms.GroupBox();
            this.imageFormatComboBox = new System.Windows.Forms.ComboBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.fractalTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.fractalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.renderStateStrip = new System.Windows.Forms.StatusStrip();
            this.renderTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.renderProgressProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.colorGroupBox.SuspendLayout();
            this.staticColorsContainerPanel.SuspendLayout();
            this.colorsFillContainerPanel.SuspendLayout();
            this.propertiesGroupBox.SuspendLayout();
            this.imageSaveGroupBox.SuspendLayout();
            this.fractalTypeGroupBox.SuspendLayout();
            this.renderStateStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.staticColorsContainerPanel);
            this.colorGroupBox.Controls.Add(this.colorsFillContainerPanel);
            this.colorGroupBox.Location = new System.Drawing.Point(6, 95);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(139, 260);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Colors";
            // 
            // staticColorsContainerPanel
            // 
            this.staticColorsContainerPanel.Controls.Add(this.baseLabel);
            this.staticColorsContainerPanel.Controls.Add(this.fractalColorLabel);
            this.staticColorsContainerPanel.Controls.Add(this.baseColorPreviewPanel);
            this.staticColorsContainerPanel.Controls.Add(this.fractalColorPreviewPanel);
            this.staticColorsContainerPanel.Location = new System.Drawing.Point(6, 187);
            this.staticColorsContainerPanel.Name = "staticColorsContainerPanel";
            this.staticColorsContainerPanel.Size = new System.Drawing.Size(120, 67);
            this.staticColorsContainerPanel.TabIndex = 10;
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(60, 8);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(31, 13);
            this.baseLabel.TabIndex = 4;
            this.baseLabel.Text = "Base";
            // 
            // fractalColorLabel
            // 
            this.fractalColorLabel.AutoSize = true;
            this.fractalColorLabel.Location = new System.Drawing.Point(3, 8);
            this.fractalColorLabel.Name = "fractalColorLabel";
            this.fractalColorLabel.Size = new System.Drawing.Size(39, 13);
            this.fractalColorLabel.TabIndex = 3;
            this.fractalColorLabel.Text = "Fractal";
            // 
            // baseColorPreviewPanel
            // 
            this.baseColorPreviewPanel.Location = new System.Drawing.Point(58, 24);
            this.baseColorPreviewPanel.Name = "baseColorPreviewPanel";
            this.baseColorPreviewPanel.Size = new System.Drawing.Size(59, 40);
            this.baseColorPreviewPanel.TabIndex = 2;
            this.baseColorPreviewPanel.Click += new System.EventHandler(this.BackgroundColorChange);
            // 
            // fractalColorPreviewPanel
            // 
            this.fractalColorPreviewPanel.Location = new System.Drawing.Point(4, 24);
            this.fractalColorPreviewPanel.Name = "fractalColorPreviewPanel";
            this.fractalColorPreviewPanel.Size = new System.Drawing.Size(54, 40);
            this.fractalColorPreviewPanel.TabIndex = 1;
            this.fractalColorPreviewPanel.Click += new System.EventHandler(this.FractalColorChange);
            // 
            // colorsFillContainerPanel
            // 
            this.colorsFillContainerPanel.Controls.Add(this.greenStartvScrollBar);
            this.colorsFillContainerPanel.Controls.Add(this.blueStartEndPreviewPanel);
            this.colorsFillContainerPanel.Controls.Add(this.redStartvScrollBar);
            this.colorsFillContainerPanel.Controls.Add(this.blueEndvScrollBar);
            this.colorsFillContainerPanel.Controls.Add(this.redEndvScrollBar);
            this.colorsFillContainerPanel.Controls.Add(this.blueStartvScrollBar);
            this.colorsFillContainerPanel.Controls.Add(this.redStartEndPreviewPanel);
            this.colorsFillContainerPanel.Controls.Add(this.greenStartEndPreviewPanel);
            this.colorsFillContainerPanel.Controls.Add(this.greenEndvScrollBar);
            this.colorsFillContainerPanel.Location = new System.Drawing.Point(6, 19);
            this.colorsFillContainerPanel.Name = "colorsFillContainerPanel";
            this.colorsFillContainerPanel.Size = new System.Drawing.Size(120, 162);
            this.colorsFillContainerPanel.TabIndex = 9;
            // 
            // greenStartvScrollBar
            // 
            this.greenStartvScrollBar.Location = new System.Drawing.Point(41, 7);
            this.greenStartvScrollBar.Maximum = 255;
            this.greenStartvScrollBar.Name = "greenStartvScrollBar";
            this.greenStartvScrollBar.Size = new System.Drawing.Size(17, 80);
            this.greenStartvScrollBar.TabIndex = 3;
            this.greenStartvScrollBar.ValueChanged += new System.EventHandler(this.ColorsFillValueChanged);
            // 
            // blueStartEndPreviewPanel
            // 
            this.blueStartEndPreviewPanel.Location = new System.Drawing.Point(78, 140);
            this.blueStartEndPreviewPanel.Name = "blueStartEndPreviewPanel";
            this.blueStartEndPreviewPanel.Size = new System.Drawing.Size(34, 19);
            this.blueStartEndPreviewPanel.TabIndex = 8;
            // 
            // redStartvScrollBar
            // 
            this.redStartvScrollBar.Location = new System.Drawing.Point(4, 7);
            this.redStartvScrollBar.Maximum = 255;
            this.redStartvScrollBar.Name = "redStartvScrollBar";
            this.redStartvScrollBar.Size = new System.Drawing.Size(17, 80);
            this.redStartvScrollBar.TabIndex = 0;
            this.redStartvScrollBar.ValueChanged += new System.EventHandler(this.ColorsFillValueChanged);
            // 
            // blueEndvScrollBar
            // 
            this.blueEndvScrollBar.Location = new System.Drawing.Point(95, 7);
            this.blueEndvScrollBar.Maximum = 255;
            this.blueEndvScrollBar.Name = "blueEndvScrollBar";
            this.blueEndvScrollBar.Size = new System.Drawing.Size(17, 80);
            this.blueEndvScrollBar.TabIndex = 7;
            this.blueEndvScrollBar.ValueChanged += new System.EventHandler(this.ColorsFillValueChanged);
            // 
            // redEndvScrollBar
            // 
            this.redEndvScrollBar.Location = new System.Drawing.Point(21, 7);
            this.redEndvScrollBar.Maximum = 255;
            this.redEndvScrollBar.Name = "redEndvScrollBar";
            this.redEndvScrollBar.Size = new System.Drawing.Size(17, 80);
            this.redEndvScrollBar.TabIndex = 1;
            this.redEndvScrollBar.ValueChanged += new System.EventHandler(this.ColorsFillValueChanged);
            // 
            // blueStartvScrollBar
            // 
            this.blueStartvScrollBar.Location = new System.Drawing.Point(78, 7);
            this.blueStartvScrollBar.Maximum = 255;
            this.blueStartvScrollBar.Name = "blueStartvScrollBar";
            this.blueStartvScrollBar.Size = new System.Drawing.Size(17, 80);
            this.blueStartvScrollBar.TabIndex = 6;
            this.blueStartvScrollBar.ValueChanged += new System.EventHandler(this.ColorsFillValueChanged);
            // 
            // redStartEndPreviewPanel
            // 
            this.redStartEndPreviewPanel.Location = new System.Drawing.Point(4, 140);
            this.redStartEndPreviewPanel.Name = "redStartEndPreviewPanel";
            this.redStartEndPreviewPanel.Size = new System.Drawing.Size(34, 19);
            this.redStartEndPreviewPanel.TabIndex = 2;
            // 
            // greenStartEndPreviewPanel
            // 
            this.greenStartEndPreviewPanel.Location = new System.Drawing.Point(41, 140);
            this.greenStartEndPreviewPanel.Name = "greenStartEndPreviewPanel";
            this.greenStartEndPreviewPanel.Size = new System.Drawing.Size(34, 19);
            this.greenStartEndPreviewPanel.TabIndex = 5;
            // 
            // greenEndvScrollBar
            // 
            this.greenEndvScrollBar.Location = new System.Drawing.Point(58, 7);
            this.greenEndvScrollBar.Maximum = 255;
            this.greenEndvScrollBar.Name = "greenEndvScrollBar";
            this.greenEndvScrollBar.Size = new System.Drawing.Size(17, 80);
            this.greenEndvScrollBar.TabIndex = 4;
            this.greenEndvScrollBar.ValueChanged += new System.EventHandler(this.ColorsFillValueChanged);
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Controls.Add(this.imaginaryConst);
            this.propertiesGroupBox.Controls.Add(this.realConstLabel);
            this.propertiesGroupBox.Controls.Add(this.imaginaryConstTextBox);
            this.propertiesGroupBox.Controls.Add(this.realConstTextBox);
            this.propertiesGroupBox.Controls.Add(this.singleIterationMode);
            this.propertiesGroupBox.Controls.Add(this.renderButton);
            this.propertiesGroupBox.Controls.Add(this.iterationsLabel);
            this.propertiesGroupBox.Controls.Add(this.iterationshScrollBar);
            this.propertiesGroupBox.Controls.Add(this.sideLenght);
            this.propertiesGroupBox.Controls.Add(this.iterationsTextBox);
            this.propertiesGroupBox.Controls.Add(this.startPositionLabel);
            this.propertiesGroupBox.Controls.Add(this.heightLabel);
            this.propertiesGroupBox.Controls.Add(this.widthLabel);
            this.propertiesGroupBox.Controls.Add(this.sideLenghtTextBox);
            this.propertiesGroupBox.Controls.Add(this.imageHeightTextBox);
            this.propertiesGroupBox.Controls.Add(this.imageWidthTextBox);
            this.propertiesGroupBox.Controls.Add(this.startPositionTextBox);
            this.propertiesGroupBox.Location = new System.Drawing.Point(293, 12);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(132, 276);
            this.propertiesGroupBox.TabIndex = 1;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Render";
            // 
            // imaginaryConst
            // 
            this.imaginaryConst.AutoSize = true;
            this.imaginaryConst.Location = new System.Drawing.Point(7, 152);
            this.imaginaryConst.Name = "imaginaryConst";
            this.imaginaryConst.Size = new System.Drawing.Size(59, 13);
            this.imaginaryConst.TabIndex = 16;
            this.imaginaryConst.Text = "Imag const";
            // 
            // realConstLabel
            // 
            this.realConstLabel.AutoSize = true;
            this.realConstLabel.Location = new System.Drawing.Point(7, 126);
            this.realConstLabel.Name = "realConstLabel";
            this.realConstLabel.Size = new System.Drawing.Size(58, 13);
            this.realConstLabel.TabIndex = 15;
            this.realConstLabel.Text = "Real const";
            // 
            // imaginaryConstTextBox
            // 
            this.imaginaryConstTextBox.Location = new System.Drawing.Point(69, 149);
            this.imaginaryConstTextBox.Name = "imaginaryConstTextBox";
            this.imaginaryConstTextBox.Size = new System.Drawing.Size(57, 20);
            this.imaginaryConstTextBox.TabIndex = 14;
            this.imaginaryConstTextBox.Text = "-0.6";
            // 
            // realConstTextBox
            // 
            this.realConstTextBox.Location = new System.Drawing.Point(69, 123);
            this.realConstTextBox.Name = "realConstTextBox";
            this.realConstTextBox.Size = new System.Drawing.Size(57, 20);
            this.realConstTextBox.TabIndex = 13;
            this.realConstTextBox.Text = "-0.1";
            // 
            // singleIterationMode
            // 
            this.singleIterationMode.AutoSize = true;
            this.singleIterationMode.Location = new System.Drawing.Point(6, 218);
            this.singleIterationMode.Name = "singleIterationMode";
            this.singleIterationMode.Size = new System.Drawing.Size(96, 17);
            this.singleIterationMode.TabIndex = 12;
            this.singleIterationMode.Text = "Single Iteration";
            this.singleIterationMode.UseVisualStyleBackColor = true;
            // 
            // renderButton
            // 
            this.renderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.renderButton.Font = new System.Drawing.Font("Mangal", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.renderButton.Location = new System.Drawing.Point(6, 241);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(120, 27);
            this.renderButton.TabIndex = 11;
            this.renderButton.TabStop = false;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.RenderFractal);
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(7, 178);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(50, 13);
            this.iterationsLabel.TabIndex = 9;
            this.iterationsLabel.Text = "Iterations";
            // 
            // iterationshScrollBar
            // 
            this.iterationshScrollBar.Location = new System.Drawing.Point(6, 198);
            this.iterationshScrollBar.Maximum = 1009;
            this.iterationshScrollBar.Minimum = 1;
            this.iterationshScrollBar.Name = "iterationshScrollBar";
            this.iterationshScrollBar.Size = new System.Drawing.Size(120, 17);
            this.iterationshScrollBar.TabIndex = 4;
            this.iterationshScrollBar.Value = 15;
            this.iterationshScrollBar.ValueChanged += new System.EventHandler(this.IterationsChanged);
            // 
            // sideLenght
            // 
            this.sideLenght.AutoSize = true;
            this.sideLenght.Location = new System.Drawing.Point(7, 100);
            this.sideLenght.Name = "sideLenght";
            this.sideLenght.Size = new System.Drawing.Size(60, 13);
            this.sideLenght.TabIndex = 8;
            this.sideLenght.Text = "Side lenght";
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(69, 175);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.ReadOnly = true;
            this.iterationsTextBox.Size = new System.Drawing.Size(57, 20);
            this.iterationsTextBox.TabIndex = 2;
            this.iterationsTextBox.TabStop = false;
            this.iterationsTextBox.Text = "15";
            // 
            // startPositionLabel
            // 
            this.startPositionLabel.AutoSize = true;
            this.startPositionLabel.Location = new System.Drawing.Point(7, 74);
            this.startPositionLabel.Name = "startPositionLabel";
            this.startPositionLabel.Size = new System.Drawing.Size(61, 13);
            this.startPositionLabel.TabIndex = 7;
            this.startPositionLabel.Text = "Start [ X:Y ]";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 48);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(7, 22);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width";
            // 
            // sideLenghtTextBox
            // 
            this.sideLenghtTextBox.Location = new System.Drawing.Point(69, 97);
            this.sideLenghtTextBox.Name = "sideLenghtTextBox";
            this.sideLenghtTextBox.Size = new System.Drawing.Size(57, 20);
            this.sideLenghtTextBox.TabIndex = 3;
            this.sideLenghtTextBox.Text = "2.5";
            // 
            // imageHeightTextBox
            // 
            this.imageHeightTextBox.Location = new System.Drawing.Point(69, 45);
            this.imageHeightTextBox.Name = "imageHeightTextBox";
            this.imageHeightTextBox.Size = new System.Drawing.Size(57, 20);
            this.imageHeightTextBox.TabIndex = 1;
            this.imageHeightTextBox.Text = "300";
            // 
            // imageWidthTextBox
            // 
            this.imageWidthTextBox.Location = new System.Drawing.Point(69, 19);
            this.imageWidthTextBox.Name = "imageWidthTextBox";
            this.imageWidthTextBox.Size = new System.Drawing.Size(57, 20);
            this.imageWidthTextBox.TabIndex = 0;
            this.imageWidthTextBox.Text = "300";
            // 
            // startPositionTextBox
            // 
            this.startPositionTextBox.Location = new System.Drawing.Point(69, 71);
            this.startPositionTextBox.Name = "startPositionTextBox";
            this.startPositionTextBox.Size = new System.Drawing.Size(57, 20);
            this.startPositionTextBox.TabIndex = 2;
            this.startPositionTextBox.Text = "-2.0:-1.25";
            // 
            // imageSaveGroupBox
            // 
            this.imageSaveGroupBox.Controls.Add(this.imageFormatComboBox);
            this.imageSaveGroupBox.Controls.Add(this.saveImageButton);
            this.imageSaveGroupBox.Location = new System.Drawing.Point(6, 12);
            this.imageSaveGroupBox.Name = "imageSaveGroupBox";
            this.imageSaveGroupBox.Size = new System.Drawing.Size(139, 77);
            this.imageSaveGroupBox.TabIndex = 2;
            this.imageSaveGroupBox.TabStop = false;
            this.imageSaveGroupBox.Text = "Image";
            // 
            // imageFormatComboBox
            // 
            this.imageFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageFormatComboBox.FormattingEnabled = true;
            this.imageFormatComboBox.Location = new System.Drawing.Point(6, 19);
            this.imageFormatComboBox.Name = "imageFormatComboBox";
            this.imageFormatComboBox.Size = new System.Drawing.Size(127, 21);
            this.imageFormatComboBox.TabIndex = 1;
            this.imageFormatComboBox.TabStop = false;
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(6, 46);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(127, 23);
            this.saveImageButton.TabIndex = 0;
            this.saveImageButton.TabStop = false;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.SaveImage);
            // 
            // fractalTypeGroupBox
            // 
            this.fractalTypeGroupBox.Controls.Add(this.fractalTypeComboBox);
            this.fractalTypeGroupBox.Location = new System.Drawing.Point(293, 294);
            this.fractalTypeGroupBox.Name = "fractalTypeGroupBox";
            this.fractalTypeGroupBox.Size = new System.Drawing.Size(132, 61);
            this.fractalTypeGroupBox.TabIndex = 3;
            this.fractalTypeGroupBox.TabStop = false;
            this.fractalTypeGroupBox.Text = "Fractal";
            // 
            // fractalTypeComboBox
            // 
            this.fractalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fractalTypeComboBox.FormattingEnabled = true;
            this.fractalTypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.fractalTypeComboBox.Name = "fractalTypeComboBox";
            this.fractalTypeComboBox.Size = new System.Drawing.Size(120, 21);
            this.fractalTypeComboBox.TabIndex = 0;
            // 
            // renderStateStrip
            // 
            this.renderStateStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderTimeLabel,
            this.renderProgressProgressBar});
            this.renderStateStrip.Location = new System.Drawing.Point(0, 359);
            this.renderStateStrip.Name = "renderStateStrip";
            this.renderStateStrip.Size = new System.Drawing.Size(437, 22);
            this.renderStateStrip.SizingGrip = false;
            this.renderStateStrip.TabIndex = 4;
            this.renderStateStrip.Text = "statusStrip1";
            // 
            // renderTimeLabel
            // 
            this.renderTimeLabel.Name = "renderTimeLabel";
            this.renderTimeLabel.Size = new System.Drawing.Size(37, 17);
            this.renderTimeLabel.Text = "Time:";
            // 
            // renderProgressProgressBar
            // 
            this.renderProgressProgressBar.Name = "renderProgressProgressBar";
            this.renderProgressProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // PropertiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 381);
            this.Controls.Add(this.renderStateStrip);
            this.Controls.Add(this.fractalTypeGroupBox);
            this.Controls.Add(this.imageSaveGroupBox);
            this.Controls.Add(this.propertiesGroupBox);
            this.Controls.Add(this.colorGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PropertiesWindow";
            this.Text = "PropertiesWindow";
            this.Shown += new System.EventHandler(this.WindowShow);
            this.colorGroupBox.ResumeLayout(false);
            this.staticColorsContainerPanel.ResumeLayout(false);
            this.staticColorsContainerPanel.PerformLayout();
            this.colorsFillContainerPanel.ResumeLayout(false);
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            this.imageSaveGroupBox.ResumeLayout(false);
            this.fractalTypeGroupBox.ResumeLayout(false);
            this.renderStateStrip.ResumeLayout(false);
            this.renderStateStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Panel staticColorsContainerPanel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label fractalColorLabel;
        private System.Windows.Forms.Panel baseColorPreviewPanel;
        private System.Windows.Forms.Panel fractalColorPreviewPanel;
        private System.Windows.Forms.Panel colorsFillContainerPanel;
        private System.Windows.Forms.VScrollBar greenStartvScrollBar;
        private System.Windows.Forms.Panel blueStartEndPreviewPanel;
        private System.Windows.Forms.VScrollBar redStartvScrollBar;
        private System.Windows.Forms.VScrollBar blueEndvScrollBar;
        private System.Windows.Forms.VScrollBar redEndvScrollBar;
        private System.Windows.Forms.VScrollBar blueStartvScrollBar;
        private System.Windows.Forms.Panel redStartEndPreviewPanel;
        private System.Windows.Forms.Panel greenStartEndPreviewPanel;
        private System.Windows.Forms.VScrollBar greenEndvScrollBar;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.HScrollBar iterationshScrollBar;
        private System.Windows.Forms.Label sideLenght;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.Label startPositionLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox sideLenghtTextBox;
        private System.Windows.Forms.TextBox imageHeightTextBox;
        private System.Windows.Forms.TextBox imageWidthTextBox;
        private System.Windows.Forms.TextBox startPositionTextBox;
        private System.Windows.Forms.CheckBox singleIterationMode;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.GroupBox imageSaveGroupBox;
        private System.Windows.Forms.ComboBox imageFormatComboBox;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.GroupBox fractalTypeGroupBox;
        private System.Windows.Forms.ComboBox fractalTypeComboBox;
        private System.Windows.Forms.StatusStrip renderStateStrip;
        private System.Windows.Forms.ToolStripStatusLabel renderTimeLabel;
        private System.Windows.Forms.ToolStripProgressBar renderProgressProgressBar;
        private System.Windows.Forms.Label imaginaryConst;
        private System.Windows.Forms.Label realConstLabel;
        private System.Windows.Forms.TextBox imaginaryConstTextBox;
        private System.Windows.Forms.TextBox realConstTextBox;
    }
}