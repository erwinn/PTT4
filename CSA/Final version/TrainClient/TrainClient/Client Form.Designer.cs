namespace TrainClient
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
            this.components = new System.ComponentModel.Container();
            this.btnSwitchTrack = new System.Windows.Forms.Button();
            this.btnStopTrain = new System.Windows.Forms.Button();
            this.btnWriteActuator = new System.Windows.Forms.Button();
            this.gbSwitchTrack = new System.Windows.Forms.GroupBox();
            this.cbSwitchState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.gbTrain = new System.Windows.Forms.GroupBox();
            this.tbRPM = new System.Windows.Forms.TextBox();
            this.lblActualSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblState2 = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.tbDanger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LdrReadClock = new System.Windows.Forms.Timer(this.components);
            this.subscribebtn = new System.Windows.Forms.Button();
            this.unsubscribebtn = new System.Windows.Forms.Button();
            this.gbLaserArray = new System.Windows.Forms.GroupBox();
            this.lblNoConnection = new System.Windows.Forms.Label();
            this.gbSwitchTrack.SuspendLayout();
            this.gbTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.gbLaserArray.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitchTrack
            // 
            this.btnSwitchTrack.Location = new System.Drawing.Point(8, 150);
            this.btnSwitchTrack.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitchTrack.Name = "btnSwitchTrack";
            this.btnSwitchTrack.Size = new System.Drawing.Size(160, 58);
            this.btnSwitchTrack.TabIndex = 2;
            this.btnSwitchTrack.Text = "Switch Track";
            this.btnSwitchTrack.UseVisualStyleBackColor = true;
            this.btnSwitchTrack.Click += new System.EventHandler(this.btnSwitchTrack_Click);
            // 
            // btnStopTrain
            // 
            this.btnStopTrain.Location = new System.Drawing.Point(8, 116);
            this.btnStopTrain.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopTrain.Name = "btnStopTrain";
            this.btnStopTrain.Size = new System.Drawing.Size(189, 48);
            this.btnStopTrain.TabIndex = 3;
            this.btnStopTrain.Text = "Stop Train";
            this.btnStopTrain.UseVisualStyleBackColor = true;
            this.btnStopTrain.Click += new System.EventHandler(this.btnStopTrain_Click);
            // 
            // btnWriteActuator
            // 
            this.btnWriteActuator.Location = new System.Drawing.Point(220, 116);
            this.btnWriteActuator.Margin = new System.Windows.Forms.Padding(4);
            this.btnWriteActuator.Name = "btnWriteActuator";
            this.btnWriteActuator.Size = new System.Drawing.Size(101, 48);
            this.btnWriteActuator.TabIndex = 4;
            this.btnWriteActuator.Text = "Write Speed";
            this.btnWriteActuator.UseVisualStyleBackColor = true;
            this.btnWriteActuator.Click += new System.EventHandler(this.btnWriteActuator_Click_1);
            // 
            // gbSwitchTrack
            // 
            this.gbSwitchTrack.Controls.Add(this.cbSwitchState);
            this.gbSwitchTrack.Controls.Add(this.lblState);
            this.gbSwitchTrack.Controls.Add(this.btnSwitchTrack);
            this.gbSwitchTrack.Location = new System.Drawing.Point(356, 27);
            this.gbSwitchTrack.Margin = new System.Windows.Forms.Padding(4);
            this.gbSwitchTrack.Name = "gbSwitchTrack";
            this.gbSwitchTrack.Padding = new System.Windows.Forms.Padding(4);
            this.gbSwitchTrack.Size = new System.Drawing.Size(193, 220);
            this.gbSwitchTrack.TabIndex = 5;
            this.gbSwitchTrack.TabStop = false;
            this.gbSwitchTrack.Text = "Switch Track";
            this.gbSwitchTrack.Visible = false;
            // 
            // cbSwitchState
            // 
            this.cbSwitchState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwitchState.FormattingEnabled = true;
            this.cbSwitchState.Location = new System.Drawing.Point(13, 105);
            this.cbSwitchState.Margin = new System.Windows.Forms.Padding(4);
            this.cbSwitchState.Name = "cbSwitchState";
            this.cbSwitchState.Size = new System.Drawing.Size(160, 24);
            this.cbSwitchState.TabIndex = 8;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(9, 85);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // gbTrain
            // 
            this.gbTrain.Controls.Add(this.tbRPM);
            this.gbTrain.Controls.Add(this.lblActualSpeed);
            this.gbTrain.Controls.Add(this.label4);
            this.gbTrain.Controls.Add(this.lblRPM);
            this.gbTrain.Controls.Add(this.btnWriteActuator);
            this.gbTrain.Controls.Add(this.lblState2);
            this.gbTrain.Controls.Add(this.numSpeed);
            this.gbTrain.Controls.Add(this.btnStopTrain);
            this.gbTrain.Location = new System.Drawing.Point(16, 15);
            this.gbTrain.Margin = new System.Windows.Forms.Padding(4);
            this.gbTrain.Name = "gbTrain";
            this.gbTrain.Padding = new System.Windows.Forms.Padding(4);
            this.gbTrain.Size = new System.Drawing.Size(332, 193);
            this.gbTrain.TabIndex = 6;
            this.gbTrain.TabStop = false;
            this.gbTrain.Text = "Train";
            // 
            // tbRPM
            // 
            this.tbRPM.Location = new System.Drawing.Point(129, 76);
            this.tbRPM.Margin = new System.Windows.Forms.Padding(4);
            this.tbRPM.Name = "tbRPM";
            this.tbRPM.ReadOnly = true;
            this.tbRPM.Size = new System.Drawing.Size(77, 22);
            this.tbRPM.TabIndex = 12;
            // 
            // lblActualSpeed
            // 
            this.lblActualSpeed.AutoSize = true;
            this.lblActualSpeed.Location = new System.Drawing.Point(21, 80);
            this.lblActualSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualSpeed.Name = "lblActualSpeed";
            this.lblActualSpeed.Size = new System.Drawing.Size(96, 17);
            this.lblActualSpeed.TabIndex = 11;
            this.lblActualSpeed.Text = "Actual Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "RPM";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Location = new System.Drawing.Point(216, 33);
            this.lblRPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(38, 17);
            this.lblRPM.TabIndex = 10;
            this.lblRPM.Text = "RPM";
            // 
            // lblState2
            // 
            this.lblState2.AutoSize = true;
            this.lblState2.Location = new System.Drawing.Point(21, 33);
            this.lblState2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState2.Name = "lblState2";
            this.lblState2.Size = new System.Drawing.Size(53, 17);
            this.lblState2.TabIndex = 5;
            this.lblState2.Text = "Speed:";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(84, 31);
            this.numSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.numSpeed.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(124, 22);
            this.numSpeed.TabIndex = 9;
            this.numSpeed.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // tbDanger
            // 
            this.tbDanger.Location = new System.Drawing.Point(25, 43);
            this.tbDanger.Margin = new System.Windows.Forms.Padding(4);
            this.tbDanger.Name = "tbDanger";
            this.tbDanger.ReadOnly = true;
            this.tbDanger.Size = new System.Drawing.Size(132, 22);
            this.tbDanger.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Real time Laser value:";
            // 
            // LdrReadClock
            // 
            this.LdrReadClock.Enabled = true;
            this.LdrReadClock.Interval = 500;
            this.LdrReadClock.Tick += new System.EventHandler(this.LdrReadClock_Tick);
            // 
            // subscribebtn
            // 
            this.subscribebtn.Location = new System.Drawing.Point(221, 254);
            this.subscribebtn.Margin = new System.Windows.Forms.Padding(4);
            this.subscribebtn.Name = "subscribebtn";
            this.subscribebtn.Size = new System.Drawing.Size(116, 28);
            this.subscribebtn.TabIndex = 11;
            this.subscribebtn.Text = "Subscribe";
            this.subscribebtn.UseVisualStyleBackColor = true;
            this.subscribebtn.Click += new System.EventHandler(this.subscribebtn_Click);
            // 
            // unsubscribebtn
            // 
            this.unsubscribebtn.Enabled = false;
            this.unsubscribebtn.Location = new System.Drawing.Point(221, 289);
            this.unsubscribebtn.Margin = new System.Windows.Forms.Padding(4);
            this.unsubscribebtn.Name = "unsubscribebtn";
            this.unsubscribebtn.Size = new System.Drawing.Size(116, 28);
            this.unsubscribebtn.TabIndex = 12;
            this.unsubscribebtn.Text = "Unsubscribe";
            this.unsubscribebtn.UseVisualStyleBackColor = true;
            this.unsubscribebtn.Click += new System.EventHandler(this.unsubscribebtn_Click);
            // 
            // gbLaserArray
            // 
            this.gbLaserArray.Controls.Add(this.tbDanger);
            this.gbLaserArray.Controls.Add(this.label3);
            this.gbLaserArray.Location = new System.Drawing.Point(16, 254);
            this.gbLaserArray.Margin = new System.Windows.Forms.Padding(4);
            this.gbLaserArray.Name = "gbLaserArray";
            this.gbLaserArray.Padding = new System.Windows.Forms.Padding(4);
            this.gbLaserArray.Size = new System.Drawing.Size(193, 89);
            this.gbLaserArray.TabIndex = 13;
            this.gbLaserArray.TabStop = false;
            this.gbLaserArray.Text = "Laser Array:";
            // 
            // lblNoConnection
            // 
            this.lblNoConnection.AutoSize = true;
            this.lblNoConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoConnection.ForeColor = System.Drawing.Color.Red;
            this.lblNoConnection.Location = new System.Drawing.Point(406, 6);
            this.lblNoConnection.Name = "lblNoConnection";
            this.lblNoConnection.Size = new System.Drawing.Size(174, 17);
            this.lblNoConnection.TabIndex = 14;
            this.lblNoConnection.Text = "There\'s no connection!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 370);
            this.Controls.Add(this.lblNoConnection);
            this.Controls.Add(this.gbLaserArray);
            this.Controls.Add(this.unsubscribebtn);
            this.Controls.Add(this.subscribebtn);
            this.Controls.Add(this.gbTrain);
            this.Controls.Add(this.gbSwitchTrack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Train UI";
            this.gbSwitchTrack.ResumeLayout(false);
            this.gbSwitchTrack.PerformLayout();
            this.gbTrain.ResumeLayout(false);
            this.gbTrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.gbLaserArray.ResumeLayout(false);
            this.gbLaserArray.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchTrack;
        private System.Windows.Forms.Button btnStopTrain;
        private System.Windows.Forms.Button btnWriteActuator;
        private System.Windows.Forms.GroupBox gbSwitchTrack;
        private System.Windows.Forms.GroupBox gbTrain;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblState2;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDanger;
        internal System.Windows.Forms.Timer LdrReadClock;
        private System.Windows.Forms.Button subscribebtn;
        private System.Windows.Forms.Button unsubscribebtn;
        private System.Windows.Forms.ComboBox cbSwitchState;
        private System.Windows.Forms.Label lblActualSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.TextBox tbRPM;
        private System.Windows.Forms.GroupBox gbLaserArray;
        private System.Windows.Forms.Label lblNoConnection;
    }
}

