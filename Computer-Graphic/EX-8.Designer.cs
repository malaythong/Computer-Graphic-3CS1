
namespace Computer_Graphic
{
    partial class EX_8
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
            this.btnTranslation = new System.Windows.Forms.Button();
            this.btnRotation = new System.Windows.Forms.Button();
            this.btnScaling = new System.Windows.Forms.Button();
            this.bynShaering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTranslation
            // 
            this.btnTranslation.Location = new System.Drawing.Point(866, 41);
            this.btnTranslation.Name = "btnTranslation";
            this.btnTranslation.Size = new System.Drawing.Size(98, 49);
            this.btnTranslation.TabIndex = 0;
            this.btnTranslation.Text = "Translation";
            this.btnTranslation.UseVisualStyleBackColor = true;
            this.btnTranslation.Click += new System.EventHandler(this.btnTranslation_Click);
            // 
            // btnRotation
            // 
            this.btnRotation.Location = new System.Drawing.Point(866, 96);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(98, 49);
            this.btnRotation.TabIndex = 1;
            this.btnRotation.Text = "Rotation";
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // btnScaling
            // 
            this.btnScaling.Location = new System.Drawing.Point(866, 151);
            this.btnScaling.Name = "btnScaling";
            this.btnScaling.Size = new System.Drawing.Size(98, 49);
            this.btnScaling.TabIndex = 2;
            this.btnScaling.Text = "Scaling";
            this.btnScaling.UseVisualStyleBackColor = true;
            this.btnScaling.Click += new System.EventHandler(this.btnScaling_Click);
            // 
            // bynShaering
            // 
            this.bynShaering.Location = new System.Drawing.Point(866, 206);
            this.bynShaering.Name = "bynShaering";
            this.bynShaering.Size = new System.Drawing.Size(98, 49);
            this.bynShaering.TabIndex = 3;
            this.bynShaering.Text = "Shaering";
            this.bynShaering.UseVisualStyleBackColor = true;
            this.bynShaering.Click += new System.EventHandler(this.bynShaering_Click);
            // 
            // EX_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 691);
            this.Controls.Add(this.bynShaering);
            this.Controls.Add(this.btnScaling);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnTranslation);
            this.Name = "EX_8";
            this.Text = "EX_8";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EX_8_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTranslation;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.Button btnScaling;
        private System.Windows.Forms.Button bynShaering;
    }
}