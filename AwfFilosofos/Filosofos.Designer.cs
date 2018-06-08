namespace AwfFilosofos
{
    partial class Filosofos
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
            this.lblFilosofo1 = new System.Windows.Forms.Label();
            this.lblFilosofo2 = new System.Windows.Forms.Label();
            this.lblFilosofo3 = new System.Windows.Forms.Label();
            this.lblFolosofo4 = new System.Windows.Forms.Label();
            this.lblFilosofo5 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilosofo1
            // 
            this.lblFilosofo1.AutoSize = true;
            this.lblFilosofo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilosofo1.Location = new System.Drawing.Point(230, 71);
            this.lblFilosofo1.Name = "lblFilosofo1";
            this.lblFilosofo1.Size = new System.Drawing.Size(2, 15);
            this.lblFilosofo1.TabIndex = 0;
            // 
            // lblFilosofo2
            // 
            this.lblFilosofo2.AutoSize = true;
            this.lblFilosofo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilosofo2.Location = new System.Drawing.Point(133, 128);
            this.lblFilosofo2.Name = "lblFilosofo2";
            this.lblFilosofo2.Size = new System.Drawing.Size(2, 15);
            this.lblFilosofo2.TabIndex = 1;
            // 
            // lblFilosofo3
            // 
            this.lblFilosofo3.AutoSize = true;
            this.lblFilosofo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilosofo3.Location = new System.Drawing.Point(161, 207);
            this.lblFilosofo3.Name = "lblFilosofo3";
            this.lblFilosofo3.Size = new System.Drawing.Size(2, 15);
            this.lblFilosofo3.TabIndex = 2;
            // 
            // lblFolosofo4
            // 
            this.lblFolosofo4.AutoSize = true;
            this.lblFolosofo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFolosofo4.Location = new System.Drawing.Point(298, 207);
            this.lblFolosofo4.Name = "lblFolosofo4";
            this.lblFolosofo4.Size = new System.Drawing.Size(2, 15);
            this.lblFolosofo4.TabIndex = 3;
            // 
            // lblFilosofo5
            // 
            this.lblFilosofo5.AutoSize = true;
            this.lblFilosofo5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilosofo5.Location = new System.Drawing.Point(336, 128);
            this.lblFilosofo5.Name = "lblFilosofo5";
            this.lblFilosofo5.Size = new System.Drawing.Size(2, 15);
            this.lblFilosofo5.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(428, 47);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Filosofos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 421);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblFilosofo5);
            this.Controls.Add(this.lblFolosofo4);
            this.Controls.Add(this.lblFilosofo3);
            this.Controls.Add(this.lblFilosofo2);
            this.Controls.Add(this.lblFilosofo1);
            this.Name = "Filosofos";
            this.Text = "Filosofos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Filosofos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilosofo1;
        private System.Windows.Forms.Label lblFilosofo2;
        private System.Windows.Forms.Label lblFilosofo3;
        private System.Windows.Forms.Label lblFolosofo4;
        private System.Windows.Forms.Label lblFilosofo5;
        private System.Windows.Forms.Button btnIniciar;
    }
}