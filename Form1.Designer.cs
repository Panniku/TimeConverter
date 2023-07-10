namespace TimeConverter
{
    partial class TimeUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeUI));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timeList = new System.Windows.Forms.ListView();
            this.area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.refresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(11, 11);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 1;
            this.toolTip1.SetToolTip(this.datePicker, "Choose date (Use arrow keys to change values)");
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // timeList
            // 
            this.timeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.area,
            this.time});
            this.timeList.FullRowSelect = true;
            this.timeList.GridLines = true;
            this.timeList.HideSelection = false;
            this.timeList.Location = new System.Drawing.Point(11, 37);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(471, 317);
            this.timeList.TabIndex = 3;
            this.timeList.UseCompatibleStateImageBehavior = false;
            this.timeList.View = System.Windows.Forms.View.Details;
            // 
            // area
            // 
            this.area.Text = "Area";
            this.area.Width = 245;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 218;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(217, 11);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(165, 20);
            this.timePicker.TabIndex = 4;
            this.toolTip2.SetToolTip(this.timePicker, "Choose time (Use arrow keys to change values)");
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(388, 11);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(20, 20);
            this.refresh.TabIndex = 5;
            this.toolTip3.SetToolTip(this.refresh, "Refresh");
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // TimeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 366);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.timeList);
            this.Controls.Add(this.datePicker);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "TimeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeConverter";
            this.Load += new System.EventHandler(this.TimeUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListView timeList;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ColumnHeader area;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

