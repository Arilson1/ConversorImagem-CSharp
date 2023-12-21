namespace ConvertImg
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
            label1 = new Label();
            textCaminho = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textByte = new TextBox();
            button2 = new Button();
            converter = new Button();
            base64 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Caminho da Imagem";
            // 
            // textCaminho
            // 
            textCaminho.Location = new Point(12, 37);
            textCaminho.Name = "textCaminho";
            textCaminho.Size = new Size(374, 23);
            textCaminho.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(392, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Byte";
            // 
            // textByte
            // 
            textByte.Location = new Point(12, 103);
            textByte.Multiline = true;
            textByte.Name = "textByte";
            textByte.Size = new Size(536, 149);
            textByte.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(473, 37);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // converter
            // 
            converter.Location = new Point(392, 71);
            converter.Name = "converter";
            converter.Size = new Size(156, 23);
            converter.TabIndex = 6;
            converter.Text = "Converter para Byte";
            converter.UseVisualStyleBackColor = true;
            converter.Click += converter_Click;
            // 
            // base64
            // 
            base64.Location = new Point(230, 71);
            base64.Name = "base64";
            base64.Size = new Size(156, 23);
            base64.TabIndex = 7;
            base64.Text = "Converter para Base64";
            base64.UseVisualStyleBackColor = true;
            base64.Click += base64_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 262);
            Controls.Add(base64);
            Controls.Add(converter);
            Controls.Add(button2);
            Controls.Add(textByte);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textCaminho);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor de Imagem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textCaminho;
        private Button button1;
        private Label label2;
        private TextBox textByte;
        private Button button2;
        private Button converter;
        private Button base64;
    }
}
