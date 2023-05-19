
namespace LABA23_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawGraph = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CoefficientTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DrawGraph
            // 
            this.DrawGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawGraph.Location = new System.Drawing.Point(339, 342);
            this.DrawGraph.Name = "DrawGraph";
            this.DrawGraph.Size = new System.Drawing.Size(311, 162);
            this.DrawGraph.TabIndex = 0;
            this.DrawGraph.Text = "Побудувати графік";
            this.DrawGraph.UseVisualStyleBackColor = true;
            this.DrawGraph.Click += new System.EventHandler(this.DrawGraph_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(902, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 106);
            this.button2.TabIndex = 1;
            this.button2.Text = "Завдання";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть коефіцієнт а";
            // 
            // CoefficientTextBox
            // 
            this.CoefficientTextBox.Location = new System.Drawing.Point(445, 83);
            this.CoefficientTextBox.Name = "CoefficientTextBox";
            this.CoefficientTextBox.Size = new System.Drawing.Size(289, 22);
            this.CoefficientTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 516);
            this.Controls.Add(this.CoefficientTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DrawGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawGraph;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CoefficientTextBox;
    }
}

