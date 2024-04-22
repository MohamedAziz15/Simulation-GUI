namespace queuing_system__Computer_Representation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ServerStateBTN = new System.Windows.Forms.Button();
            this.NumInQueueBTN = new System.Windows.Forms.Button();
            this.TimeLastEventBTN = new System.Windows.Forms.Button();
            this.NumDelayedBTN = new System.Windows.Forms.Button();
            this.TotalDelayBTN = new System.Windows.Forms.Button();
            this.AreaUnderQtBTN = new System.Windows.Forms.Button();
            this.AreaUnderBtBTN = new System.Windows.Forms.Button();
            this.ClockBTN = new System.Windows.Forms.Button();
            this.ArrivalBTN = new System.Windows.Forms.Button();
            this.DepartureBTN = new System.Windows.Forms.Button();
            this.TimeArrivalsTB = new System.Windows.Forms.TextBox();
            this.ServiceTimeTB = new System.Windows.Forms.TextBox();
            this.TimeArrivalsLBL = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SimulateBTN = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SimulationTimeBTN = new System.Windows.Forms.Button();
            this.ReportBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intuialization Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(207, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "server state";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(310, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num. in queue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(421, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 49);
            this.label4.TabIndex = 3;
            this.label4.Text = "Times of Arrival";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(561, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 49);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time of last event ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(931, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 49);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clock ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1124, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 63);
            this.label7.TabIndex = 6;
            this.label7.Text = "Arrival";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(871, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 49);
            this.label8.TabIndex = 7;
            this.label8.Text = "Num. delayed";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(981, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 49);
            this.label9.TabIndex = 8;
            this.label9.Text = "total delay";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(1124, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 49);
            this.label10.TabIndex = 9;
            this.label10.Text = "area under Q(t)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(1273, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 49);
            this.label11.TabIndex = 10;
            this.label11.Text = "area under B(t)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(1124, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 49);
            this.label12.TabIndex = 11;
            this.label12.Text = "Departure";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerStateBTN
            // 
            this.ServerStateBTN.Location = new System.Drawing.Point(210, 316);
            this.ServerStateBTN.Name = "ServerStateBTN";
            this.ServerStateBTN.Size = new System.Drawing.Size(70, 44);
            this.ServerStateBTN.TabIndex = 12;
            this.ServerStateBTN.Text = "button1";
            this.ServerStateBTN.UseVisualStyleBackColor = true;
            // 
            // NumInQueueBTN
            // 
            this.NumInQueueBTN.Location = new System.Drawing.Point(313, 316);
            this.NumInQueueBTN.Name = "NumInQueueBTN";
            this.NumInQueueBTN.Size = new System.Drawing.Size(70, 44);
            this.NumInQueueBTN.TabIndex = 13;
            this.NumInQueueBTN.Text = "button2";
            this.NumInQueueBTN.UseVisualStyleBackColor = true;
            // 
            // TimeLastEventBTN
            // 
            this.TimeLastEventBTN.Location = new System.Drawing.Point(564, 316);
            this.TimeLastEventBTN.Name = "TimeLastEventBTN";
            this.TimeLastEventBTN.Size = new System.Drawing.Size(70, 44);
            this.TimeLastEventBTN.TabIndex = 14;
            this.TimeLastEventBTN.Text = "button3";
            this.TimeLastEventBTN.UseVisualStyleBackColor = true;
            // 
            // NumDelayedBTN
            // 
            this.NumDelayedBTN.Location = new System.Drawing.Point(874, 316);
            this.NumDelayedBTN.Name = "NumDelayedBTN";
            this.NumDelayedBTN.Size = new System.Drawing.Size(70, 44);
            this.NumDelayedBTN.TabIndex = 15;
            this.NumDelayedBTN.Text = "button4";
            this.NumDelayedBTN.UseVisualStyleBackColor = true;
            // 
            // TotalDelayBTN
            // 
            this.TotalDelayBTN.Location = new System.Drawing.Point(984, 316);
            this.TotalDelayBTN.Name = "TotalDelayBTN";
            this.TotalDelayBTN.Size = new System.Drawing.Size(70, 44);
            this.TotalDelayBTN.TabIndex = 16;
            this.TotalDelayBTN.Text = "button5";
            this.TotalDelayBTN.UseVisualStyleBackColor = true;
            // 
            // AreaUnderQtBTN
            // 
            this.AreaUnderQtBTN.Location = new System.Drawing.Point(1127, 316);
            this.AreaUnderQtBTN.Name = "AreaUnderQtBTN";
            this.AreaUnderQtBTN.Size = new System.Drawing.Size(70, 44);
            this.AreaUnderQtBTN.TabIndex = 17;
            this.AreaUnderQtBTN.Text = "button6";
            this.AreaUnderQtBTN.UseVisualStyleBackColor = true;
            // 
            // AreaUnderBtBTN
            // 
            this.AreaUnderBtBTN.Location = new System.Drawing.Point(1276, 316);
            this.AreaUnderBtBTN.Name = "AreaUnderBtBTN";
            this.AreaUnderBtBTN.Size = new System.Drawing.Size(70, 44);
            this.AreaUnderBtBTN.TabIndex = 18;
            this.AreaUnderBtBTN.Text = "button7";
            this.AreaUnderBtBTN.UseVisualStyleBackColor = true;
            // 
            // ClockBTN
            // 
            this.ClockBTN.Location = new System.Drawing.Point(931, 95);
            this.ClockBTN.Name = "ClockBTN";
            this.ClockBTN.Size = new System.Drawing.Size(70, 44);
            this.ClockBTN.TabIndex = 19;
            this.ClockBTN.Text = "button8";
            this.ClockBTN.UseVisualStyleBackColor = true;
            // 
            // ArrivalBTN
            // 
            this.ArrivalBTN.Location = new System.Drawing.Point(1212, 79);
            this.ArrivalBTN.Name = "ArrivalBTN";
            this.ArrivalBTN.Size = new System.Drawing.Size(101, 63);
            this.ArrivalBTN.TabIndex = 20;
            this.ArrivalBTN.Text = "button9";
            this.ArrivalBTN.UseVisualStyleBackColor = true;
            // 
            // DepartureBTN
            // 
            this.DepartureBTN.Location = new System.Drawing.Point(1212, 156);
            this.DepartureBTN.Name = "DepartureBTN";
            this.DepartureBTN.Size = new System.Drawing.Size(101, 49);
            this.DepartureBTN.TabIndex = 21;
            this.DepartureBTN.Text = "button10";
            this.DepartureBTN.UseVisualStyleBackColor = true;
            // 
            // TimeArrivalsTB
            // 
            this.TimeArrivalsTB.Location = new System.Drawing.Point(115, 21);
            this.TimeArrivalsTB.Name = "TimeArrivalsTB";
            this.TimeArrivalsTB.Size = new System.Drawing.Size(219, 24);
            this.TimeArrivalsTB.TabIndex = 22;
            // 
            // ServiceTimeTB
            // 
            this.ServiceTimeTB.Location = new System.Drawing.Point(115, 81);
            this.ServiceTimeTB.Name = "ServiceTimeTB";
            this.ServiceTimeTB.Size = new System.Drawing.Size(219, 24);
            this.ServiceTimeTB.TabIndex = 23;
            // 
            // TimeArrivalsLBL
            // 
            this.TimeArrivalsLBL.Location = new System.Drawing.Point(12, 13);
            this.TimeArrivalsLBL.Name = "TimeArrivalsLBL";
            this.TimeArrivalsLBL.Size = new System.Drawing.Size(73, 39);
            this.TimeArrivalsLBL.TabIndex = 25;
            this.TimeArrivalsLBL.Text = "Time Arrivals :";
            this.TimeArrivalsLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 44);
            this.label13.TabIndex = 26;
            this.label13.Text = "Service Time : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimulateBTN
            // 
            this.SimulateBTN.Location = new System.Drawing.Point(373, 21);
            this.SimulateBTN.Name = "SimulateBTN";
            this.SimulateBTN.Size = new System.Drawing.Size(110, 84);
            this.SimulateBTN.TabIndex = 27;
            this.SimulateBTN.Text = "Simulate";
            this.SimulateBTN.UseVisualStyleBackColor = true;
            this.SimulateBTN.Click += new System.EventHandler(this.SimulateBTN_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(389, 244);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 116);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SimulationTimeBTN
            // 
            this.SimulationTimeBTN.Location = new System.Drawing.Point(26, 208);
            this.SimulationTimeBTN.Name = "SimulationTimeBTN";
            this.SimulationTimeBTN.Size = new System.Drawing.Size(70, 44);
            this.SimulationTimeBTN.TabIndex = 29;
            this.SimulationTimeBTN.Text = "button1";
            this.SimulationTimeBTN.UseVisualStyleBackColor = true;
            // 
            // ReportBTN
            // 
            this.ReportBTN.Location = new System.Drawing.Point(508, 21);
            this.ReportBTN.Name = "ReportBTN";
            this.ReportBTN.Size = new System.Drawing.Size(110, 84);
            this.ReportBTN.TabIndex = 30;
            this.ReportBTN.Text = "Report";
            this.ReportBTN.UseVisualStyleBackColor = true;
            this.ReportBTN.Click += new System.EventHandler(this.ReportBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 450);
            this.Controls.Add(this.ReportBTN);
            this.Controls.Add(this.SimulationTimeBTN);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SimulateBTN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TimeArrivalsLBL);
            this.Controls.Add(this.ServiceTimeTB);
            this.Controls.Add(this.TimeArrivalsTB);
            this.Controls.Add(this.DepartureBTN);
            this.Controls.Add(this.ArrivalBTN);
            this.Controls.Add(this.ClockBTN);
            this.Controls.Add(this.AreaUnderBtBTN);
            this.Controls.Add(this.AreaUnderQtBTN);
            this.Controls.Add(this.TotalDelayBTN);
            this.Controls.Add(this.NumDelayedBTN);
            this.Controls.Add(this.TimeLastEventBTN);
            this.Controls.Add(this.NumInQueueBTN);
            this.Controls.Add(this.ServerStateBTN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ServerStateBTN;
        private System.Windows.Forms.Button NumInQueueBTN;
        private System.Windows.Forms.Button TimeLastEventBTN;
        private System.Windows.Forms.Button NumDelayedBTN;
        private System.Windows.Forms.Button TotalDelayBTN;
        private System.Windows.Forms.Button AreaUnderQtBTN;
        private System.Windows.Forms.Button AreaUnderBtBTN;
        private System.Windows.Forms.Button ClockBTN;
        private System.Windows.Forms.Button ArrivalBTN;
        private System.Windows.Forms.Button DepartureBTN;
        private System.Windows.Forms.TextBox TimeArrivalsTB;
        private System.Windows.Forms.TextBox ServiceTimeTB;
        private System.Windows.Forms.Label TimeArrivalsLBL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SimulateBTN;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SimulationTimeBTN;
        private System.Windows.Forms.Button ReportBTN;
    }
}

