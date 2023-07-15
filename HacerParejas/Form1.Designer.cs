namespace HacerParejas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblStatus = new Label();
            lblTimeLeft = new Label();
            btnReinicio = new Button();
            Temporizador = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(258, 127);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(131, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Unir o desfasar";
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimeLeft.Location = new Point(258, 202);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(202, 28);
            lblTimeLeft.TabIndex = 1;
            lblTimeLeft.Text = "Tiempo restante: 30";
            // 
            // btnReinicio
            // 
            btnReinicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReinicio.Location = new Point(258, 12);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(202, 73);
            btnReinicio.TabIndex = 2;
            btnReinicio.Text = "Reiniciar";
            btnReinicio.UseVisualStyleBackColor = true;
            btnReinicio.Click += RestartGameEvent;
            // 
            // Temporizador
            // 
            Temporizador.Interval = 1000;
            Temporizador.Tick += TimeEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 424);
            Controls.Add(btnReinicio);
            Controls.Add(lblTimeLeft);
            Controls.Add(lblStatus);
            Name = "Form1";
            ShowIcon = false;
            Text = "Memorice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label lblTimeLeft;
        private Button btnReinicio;
        private System.Windows.Forms.Timer Temporizador;
    }
}