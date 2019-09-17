namespace WindowFormTesting.customer.View
{
    partial class FrmCusList
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
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCusList));
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiRadioButton1 = new Janus.Windows.EditControls.UIRadioButton();
            this.uiRadioButton2 = new Janus.Windows.EditControls.UIRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiRadioButton3 = new Janus.Windows.EditControls.UIRadioButton();
            this.uiRadioButton4 = new Janus.Windows.EditControls.UIRadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.button1);
            this.uiGroupBox1.Controls.Add(this.panel2);
            this.uiGroupBox1.Controls.Add(this.dateTimePicker2);
            this.uiGroupBox1.Controls.Add(this.dateTimePicker1);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.panel1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(956, 56);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiRadioButton2);
            this.panel1.Controls.Add(this.uiRadioButton1);
            this.panel1.Location = new System.Drawing.Point(7, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 33);
            this.panel1.TabIndex = 1;
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Location = new System.Drawing.Point(3, 7);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Size = new System.Drawing.Size(79, 23);
            this.uiRadioButton1.TabIndex = 0;
            this.uiRadioButton1.Text = "All days";
            this.uiRadioButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Location = new System.Drawing.Point(88, 7);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Size = new System.Drawing.Size(86, 23);
            this.uiRadioButton2.TabIndex = 1;
            this.uiRadioButton2.Text = "By Date";
            this.uiRadioButton2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(409, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiRadioButton3);
            this.panel2.Controls.Add(this.uiRadioButton4);
            this.panel2.Location = new System.Drawing.Point(548, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 33);
            this.panel2.TabIndex = 2;
            // 
            // uiRadioButton3
            // 
            this.uiRadioButton3.Location = new System.Drawing.Point(88, 7);
            this.uiRadioButton3.Name = "uiRadioButton3";
            this.uiRadioButton3.Size = new System.Drawing.Size(86, 23);
            this.uiRadioButton3.TabIndex = 1;
            this.uiRadioButton3.Text = "Inactive";
            this.uiRadioButton3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // uiRadioButton4
            // 
            this.uiRadioButton4.Location = new System.Drawing.Point(3, 7);
            this.uiRadioButton4.Name = "uiRadioButton4";
            this.uiRadioButton4.Size = new System.Drawing.Size(79, 23);
            this.uiRadioButton4.TabIndex = 0;
            this.uiRadioButton4.Text = "Active";
            this.uiRadioButton4.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // button1
            // 
            this.button1.Image = global::WindowFormTesting.Properties.Resources.preview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(765, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gridEX1
            // 
            this.gridEX1.ColumnAutoResize = true;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.Location = new System.Drawing.Point(0, 62);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(956, 306);
            this.gridEX1.TabIndex = 1;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // FrmCusList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 368);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "FrmCusList";
            this.Text = "FrmCusList";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private Janus.Windows.EditControls.UIRadioButton uiRadioButton3;
        private Janus.Windows.EditControls.UIRadioButton uiRadioButton4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.EditControls.UIRadioButton uiRadioButton2;
        private Janus.Windows.EditControls.UIRadioButton uiRadioButton1;
        private Janus.Windows.GridEX.GridEX gridEX1;
    }
}