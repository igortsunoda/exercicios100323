namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.lblOpcoes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblListagemAlunos = new System.Windows.Forms.Button();
            this.lblCadastroNotas = new System.Windows.Forms.Button();
            this.lblListagemNotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpcoes
            // 
            this.lblOpcoes.AutoSize = true;
            this.lblOpcoes.Location = new System.Drawing.Point(912, 9);
            this.lblOpcoes.Name = "lblOpcoes";
            this.lblOpcoes.Size = new System.Drawing.Size(62, 20);
            this.lblOpcoes.TabIndex = 2;
            this.lblOpcoes.Text = "Opções:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastro de Alunos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblListagemAlunos
            // 
            this.lblListagemAlunos.Location = new System.Drawing.Point(873, 116);
            this.lblListagemAlunos.Name = "lblListagemAlunos";
            this.lblListagemAlunos.Size = new System.Drawing.Size(148, 29);
            this.lblListagemAlunos.TabIndex = 4;
            this.lblListagemAlunos.Text = "Listagem de Alunos";
            this.lblListagemAlunos.UseVisualStyleBackColor = true;
            // 
            // lblCadastroNotas
            // 
            this.lblCadastroNotas.Location = new System.Drawing.Point(873, 78);
            this.lblCadastroNotas.Name = "lblCadastroNotas";
            this.lblCadastroNotas.Size = new System.Drawing.Size(148, 29);
            this.lblCadastroNotas.TabIndex = 5;
            this.lblCadastroNotas.Text = "Cadastro de Notas";
            this.lblCadastroNotas.UseVisualStyleBackColor = true;
            // 
            // lblListagemNotas
            // 
            this.lblListagemNotas.Location = new System.Drawing.Point(873, 151);
            this.lblListagemNotas.Name = "lblListagemNotas";
            this.lblListagemNotas.Size = new System.Drawing.Size(148, 29);
            this.lblListagemNotas.TabIndex = 6;
            this.lblListagemNotas.Text = "Listagem de Notas";
            this.lblListagemNotas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 493);
            this.Controls.Add(this.lblListagemNotas);
            this.Controls.Add(this.lblCadastroNotas);
            this.Controls.Add(this.lblListagemAlunos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOpcoes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblOpcoes;
        private Button button1;
        private BindingSource bindingSource1;
        private Button lblListagemAlunos;
        private Button lblCadastroNotas;
        private Button lblListagemNotas;
    }
}