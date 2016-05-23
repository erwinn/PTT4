﻿namespace TrainClient
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
            this.btnSwitchTrack = new System.Windows.Forms.Button();
            this.btnStopTrain = new System.Windows.Forms.Button();
            this.btnWriteSensor = new System.Windows.Forms.Button();
            this.gbSwitchTrack = new System.Windows.Forms.GroupBox();
            this.gbStopTrain = new System.Windows.Forms.GroupBox();
            this.gbWriteSensorState = new System.Windows.Forms.GroupBox();
            this.tbTrain = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.lblTrainID = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.tbTrainID2 = new System.Windows.Forms.TextBox();
            this.lblTrainID2 = new System.Windows.Forms.Label();
            this.lblState2 = new System.Windows.Forms.Label();
            this.lblSensor = new System.Windows.Forms.Label();
            this.tbState2 = new System.Windows.Forms.TextBox();
            this.tbSensor = new System.Windows.Forms.TextBox();
            this.gbSwitchTrack.SuspendLayout();
            this.gbStopTrain.SuspendLayout();
            this.gbWriteSensorState.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitchTrack
            // 
            this.btnSwitchTrack.Location = new System.Drawing.Point(6, 189);
            this.btnSwitchTrack.Name = "btnSwitchTrack";
            this.btnSwitchTrack.Size = new System.Drawing.Size(120, 47);
            this.btnSwitchTrack.TabIndex = 2;
            this.btnSwitchTrack.Text = "Switch Track";
            this.btnSwitchTrack.UseVisualStyleBackColor = true;
            this.btnSwitchTrack.Click += new System.EventHandler(this.btnSwitchTrack_Click);
            // 
            // btnStopTrain
            // 
            this.btnStopTrain.Location = new System.Drawing.Point(6, 128);
            this.btnStopTrain.Name = "btnStopTrain";
            this.btnStopTrain.Size = new System.Drawing.Size(120, 47);
            this.btnStopTrain.TabIndex = 3;
            this.btnStopTrain.Text = "Stop Train";
            this.btnStopTrain.UseVisualStyleBackColor = true;
            this.btnStopTrain.Click += new System.EventHandler(this.btnStopTrain_Click);
            // 
            // btnWriteSensor
            // 
            this.btnWriteSensor.Location = new System.Drawing.Point(6, 133);
            this.btnWriteSensor.Name = "btnWriteSensor";
            this.btnWriteSensor.Size = new System.Drawing.Size(120, 47);
            this.btnWriteSensor.TabIndex = 4;
            this.btnWriteSensor.Text = "Write Sensor State";
            this.btnWriteSensor.UseVisualStyleBackColor = true;
            this.btnWriteSensor.Click += new System.EventHandler(this.btnWriteSensor_Click);
            // 
            // gbSwitchTrack
            // 
            this.gbSwitchTrack.Controls.Add(this.lblState);
            this.gbSwitchTrack.Controls.Add(this.lblTrainID);
            this.gbSwitchTrack.Controls.Add(this.tbState);
            this.gbSwitchTrack.Controls.Add(this.tbTrain);
            this.gbSwitchTrack.Controls.Add(this.btnSwitchTrack);
            this.gbSwitchTrack.Location = new System.Drawing.Point(42, 36);
            this.gbSwitchTrack.Name = "gbSwitchTrack";
            this.gbSwitchTrack.Size = new System.Drawing.Size(179, 242);
            this.gbSwitchTrack.TabIndex = 5;
            this.gbSwitchTrack.TabStop = false;
            this.gbSwitchTrack.Text = "Switch Track";
            // 
            // gbStopTrain
            // 
            this.gbStopTrain.Controls.Add(this.lblTrainID2);
            this.gbStopTrain.Controls.Add(this.tbTrainID2);
            this.gbStopTrain.Controls.Add(this.btnStopTrain);
            this.gbStopTrain.Location = new System.Drawing.Point(274, 36);
            this.gbStopTrain.Name = "gbStopTrain";
            this.gbStopTrain.Size = new System.Drawing.Size(200, 186);
            this.gbStopTrain.TabIndex = 6;
            this.gbStopTrain.TabStop = false;
            this.gbStopTrain.Text = "Stop Train";
            // 
            // gbWriteSensorState
            // 
            this.gbWriteSensorState.Controls.Add(this.tbSensor);
            this.gbWriteSensorState.Controls.Add(this.tbState2);
            this.gbWriteSensorState.Controls.Add(this.lblSensor);
            this.gbWriteSensorState.Controls.Add(this.lblState2);
            this.gbWriteSensorState.Controls.Add(this.btnWriteSensor);
            this.gbWriteSensorState.Location = new System.Drawing.Point(529, 36);
            this.gbWriteSensorState.Name = "gbWriteSensorState";
            this.gbWriteSensorState.Size = new System.Drawing.Size(189, 186);
            this.gbWriteSensorState.TabIndex = 7;
            this.gbWriteSensorState.TabStop = false;
            this.gbWriteSensorState.Text = "Write Sensor State";
            // 
            // tbTrain
            // 
            this.tbTrain.Location = new System.Drawing.Point(6, 71);
            this.tbTrain.Name = "tbTrain";
            this.tbTrain.Size = new System.Drawing.Size(100, 20);
            this.tbTrain.TabIndex = 3;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(6, 147);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(100, 20);
            this.tbState.TabIndex = 4;
            // 
            // lblTrainID
            // 
            this.lblTrainID.AutoSize = true;
            this.lblTrainID.Location = new System.Drawing.Point(7, 52);
            this.lblTrainID.Name = "lblTrainID";
            this.lblTrainID.Size = new System.Drawing.Size(45, 13);
            this.lblTrainID.TabIndex = 5;
            this.lblTrainID.Text = "Train ID";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(10, 128);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // tbTrainID2
            // 
            this.tbTrainID2.Location = new System.Drawing.Point(16, 89);
            this.tbTrainID2.Name = "tbTrainID2";
            this.tbTrainID2.Size = new System.Drawing.Size(100, 20);
            this.tbTrainID2.TabIndex = 4;
            // 
            // lblTrainID2
            // 
            this.lblTrainID2.AutoSize = true;
            this.lblTrainID2.Location = new System.Drawing.Point(16, 52);
            this.lblTrainID2.Name = "lblTrainID2";
            this.lblTrainID2.Size = new System.Drawing.Size(45, 13);
            this.lblTrainID2.TabIndex = 5;
            this.lblTrainID2.Text = "Train ID";
            // 
            // lblState2
            // 
            this.lblState2.AutoSize = true;
            this.lblState2.Location = new System.Drawing.Point(7, 35);
            this.lblState2.Name = "lblState2";
            this.lblState2.Size = new System.Drawing.Size(32, 13);
            this.lblState2.TabIndex = 5;
            this.lblState2.Text = "State";
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Location = new System.Drawing.Point(10, 89);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(40, 13);
            this.lblSensor.TabIndex = 6;
            this.lblSensor.Text = "Sensor";
            // 
            // tbState2
            // 
            this.tbState2.Location = new System.Drawing.Point(10, 52);
            this.tbState2.Name = "tbState2";
            this.tbState2.Size = new System.Drawing.Size(100, 20);
            this.tbState2.TabIndex = 7;
            // 
            // tbSensor
            // 
            this.tbSensor.Location = new System.Drawing.Point(13, 107);
            this.tbSensor.Name = "tbSensor";
            this.tbSensor.Size = new System.Drawing.Size(100, 20);
            this.tbSensor.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 421);
            this.Controls.Add(this.gbWriteSensorState);
            this.Controls.Add(this.gbStopTrain);
            this.Controls.Add(this.gbSwitchTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSwitchTrack.ResumeLayout(false);
            this.gbSwitchTrack.PerformLayout();
            this.gbStopTrain.ResumeLayout(false);
            this.gbStopTrain.PerformLayout();
            this.gbWriteSensorState.ResumeLayout(false);
            this.gbWriteSensorState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchTrack;
        private System.Windows.Forms.Button btnStopTrain;
        private System.Windows.Forms.Button btnWriteSensor;
        private System.Windows.Forms.GroupBox gbSwitchTrack;
        private System.Windows.Forms.GroupBox gbStopTrain;
        private System.Windows.Forms.GroupBox gbWriteSensorState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTrainID;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbTrain;
        private System.Windows.Forms.Label lblTrainID2;
        private System.Windows.Forms.TextBox tbTrainID2;
        private System.Windows.Forms.TextBox tbSensor;
        private System.Windows.Forms.TextBox tbState2;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Label lblState2;
    }
}

