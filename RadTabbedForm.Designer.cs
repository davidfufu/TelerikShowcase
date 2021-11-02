namespace TelerikShowcase
{
    partial class RadTabbedForm
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
            this.radTabbedFormControl1 = new Telerik.WinControls.UI.RadTabbedFormControl();
            this.radTabbedFormControlTab1 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textFlightDates = new System.Windows.Forms.TextBox();
            this.btnBookFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).BeginInit();
            this.radTabbedFormControl1.SuspendLayout();
            this.radTabbedFormControlTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTabbedFormControl1
            // 
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab1);
            this.radTabbedFormControl1.LeftItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1});
            this.radTabbedFormControl1.Location = new System.Drawing.Point(0, 0);
            this.radTabbedFormControl1.Name = "radTabbedFormControl1";
            this.radTabbedFormControl1.SelectedTab = this.radTabbedFormControlTab1;
            this.radTabbedFormControl1.Size = new System.Drawing.Size(792, 595);
            this.radTabbedFormControl1.TabIndex = 0;
            this.radTabbedFormControl1.Text = "RadTabbedForm";
            this.radTabbedFormControl1.SelectedTabChanged += new System.EventHandler(this.radTabbedFormControl1_SelectedTabChanged);
            // 
            // radTabbedFormControlTab1
            // 
            this.radTabbedFormControlTab1.Controls.Add(this.btnBookFlight);
            this.radTabbedFormControlTab1.Controls.Add(this.textFlightDates);
            this.radTabbedFormControlTab1.Controls.Add(this.monthCalendar1);
            this.radTabbedFormControlTab1.Location = new System.Drawing.Point(1, 37);
            this.radTabbedFormControlTab1.Name = "radTabbedFormControlTab1";
            this.radTabbedFormControlTab1.Size = new System.Drawing.Size(790, 557);
            this.radTabbedFormControlTab1.Text = "Tab 1";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.StretchHorizontally = false;
            this.radButtonElement1.StretchVertically = false;
            this.radButtonElement1.Text = "NewTab";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(55, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textFlightDates
            // 
            this.textFlightDates.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textFlightDates.Location = new System.Drawing.Point(66, 492);
            this.textFlightDates.Name = "textFlightDates";
            this.textFlightDates.Size = new System.Drawing.Size(417, 34);
            this.textFlightDates.TabIndex = 1;
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Location = new System.Drawing.Point(561, 495);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(157, 36);
            this.btnBookFlight.TabIndex = 2;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            // 
            // RadTabbedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 595);
            this.Controls.Add(this.radTabbedFormControl1);
            this.Name = "RadTabbedForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "RadTabbedForm";
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).EndInit();
            this.radTabbedFormControl1.ResumeLayout(false);
            this.radTabbedFormControlTab1.ResumeLayout(false);
            this.radTabbedFormControlTab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTabbedFormControl radTabbedFormControl1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.TextBox textFlightDates;
    }
}
