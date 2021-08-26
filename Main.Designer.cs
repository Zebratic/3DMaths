
namespace _3DMaths
{
    partial class Main
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
            this.MouseRecorder = new System.Windows.Forms.Timer(this.components);
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.MouseArea = new System.Windows.Forms.PictureBox();
            this.Drawer = new System.Windows.Forms.Timer(this.components);
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblAngle1 = new System.Windows.Forms.Label();
            this.lblAngle2 = new System.Windows.Forms.Label();
            this.lblDistance2 = new System.Windows.Forms.Label();
            this.lblDistance1 = new System.Windows.Forms.Label();
            this.cbMousePosition = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MouseArea)).BeginInit();
            this.SuspendLayout();
            // 
            // MouseRecorder
            // 
            this.MouseRecorder.Enabled = true;
            this.MouseRecorder.Interval = 10;
            this.MouseRecorder.Tick += new System.EventHandler(this.MouseRecorder_Tick);
            // 
            // lblX1
            // 
            this.lblX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(624, 9);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(17, 13);
            this.lblX1.TabIndex = 0;
            this.lblX1.Text = "X:";
            // 
            // lblY1
            // 
            this.lblY1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(624, 22);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(17, 13);
            this.lblY1.TabIndex = 1;
            this.lblY1.Text = "Y:";
            // 
            // MouseArea
            // 
            this.MouseArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MouseArea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MouseArea.Location = new System.Drawing.Point(10, 9);
            this.MouseArea.Name = "MouseArea";
            this.MouseArea.Size = new System.Drawing.Size(608, 462);
            this.MouseArea.TabIndex = 2;
            this.MouseArea.TabStop = false;
            // 
            // Drawer
            // 
            this.Drawer.Enabled = true;
            this.Drawer.Interval = 10;
            this.Drawer.Tick += new System.EventHandler(this.Drawer_Tick);
            // 
            // lblY2
            // 
            this.lblY2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(624, 94);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(17, 13);
            this.lblY2.TabIndex = 6;
            this.lblY2.Text = "Y:";
            // 
            // lblX2
            // 
            this.lblX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(624, 81);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(17, 13);
            this.lblX2.TabIndex = 7;
            this.lblX2.Text = "X:";
            // 
            // lblAngle1
            // 
            this.lblAngle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAngle1.AutoSize = true;
            this.lblAngle1.Location = new System.Drawing.Point(624, 35);
            this.lblAngle1.Name = "lblAngle1";
            this.lblAngle1.Size = new System.Drawing.Size(37, 13);
            this.lblAngle1.TabIndex = 8;
            this.lblAngle1.Text = "Angle:";
            // 
            // lblAngle2
            // 
            this.lblAngle2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAngle2.AutoSize = true;
            this.lblAngle2.Location = new System.Drawing.Point(624, 107);
            this.lblAngle2.Name = "lblAngle2";
            this.lblAngle2.Size = new System.Drawing.Size(37, 13);
            this.lblAngle2.TabIndex = 9;
            this.lblAngle2.Text = "Angle:";
            // 
            // lblDistance2
            // 
            this.lblDistance2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistance2.AutoSize = true;
            this.lblDistance2.Location = new System.Drawing.Point(624, 120);
            this.lblDistance2.Name = "lblDistance2";
            this.lblDistance2.Size = new System.Drawing.Size(52, 13);
            this.lblDistance2.TabIndex = 10;
            this.lblDistance2.Text = "Distance:";
            // 
            // lblDistance1
            // 
            this.lblDistance1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistance1.AutoSize = true;
            this.lblDistance1.Location = new System.Drawing.Point(624, 48);
            this.lblDistance1.Name = "lblDistance1";
            this.lblDistance1.Size = new System.Drawing.Size(52, 13);
            this.lblDistance1.TabIndex = 11;
            this.lblDistance1.Text = "Distance:";
            // 
            // cbMousePosition
            // 
            this.cbMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMousePosition.AutoSize = true;
            this.cbMousePosition.Location = new System.Drawing.Point(627, 156);
            this.cbMousePosition.Name = "cbMousePosition";
            this.cbMousePosition.Size = new System.Drawing.Size(98, 17);
            this.cbMousePosition.TabIndex = 12;
            this.cbMousePosition.Text = "Mouse Position";
            this.cbMousePosition.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 483);
            this.Controls.Add(this.cbMousePosition);
            this.Controls.Add(this.lblDistance1);
            this.Controls.Add(this.lblDistance2);
            this.Controls.Add(this.lblAngle2);
            this.Controls.Add(this.lblAngle1);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.MouseArea);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.lblX1);
            this.Name = "Main";
            this.Text = "3D Maths";
            ((System.ComponentModel.ISupportInitialize)(this.MouseArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MouseRecorder;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.PictureBox MouseArea;
        private System.Windows.Forms.Timer Drawer;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblAngle1;
        private System.Windows.Forms.Label lblAngle2;
        private System.Windows.Forms.Label lblDistance2;
        private System.Windows.Forms.Label lblDistance1;
        private System.Windows.Forms.CheckBox cbMousePosition;
    }
}

