namespace AgendaTelefonica.Frontend.contatos
{
    partial class FormContatos
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
            lstvContatos = new ListView();
            colId = new ColumnHeader();
            colNome = new ColumnHeader();
            colTelefone1 = new ColumnHeader();
            colTelefone2 = new ColumnHeader();
            btnPesquisar = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnRestaurar = new Button();
            cpoFiltro = new MaskedTextBox();
            lblFiltro = new Label();
            SuspendLayout();
            // 
            // lstvContatos
            // 
            lstvContatos.Columns.AddRange(new ColumnHeader[] { colId, colNome, colTelefone1, colTelefone2 });
            lstvContatos.FullRowSelect = true;
            lstvContatos.GridLines = true;
            lstvContatos.Location = new Point(12, 81);
            lstvContatos.MultiSelect = false;
            lstvContatos.Name = "lstvContatos";
            lstvContatos.Size = new Size(686, 319);
            lstvContatos.TabIndex = 0;
            lstvContatos.UseCompatibleStateImageBehavior = false;
            lstvContatos.SelectedIndexChanged += lstvContatos_SelectedIndexChanged;
            // 
            // colId
            // 
            colId.Text = "Código";
            // 
            // colNome
            // 
            colNome.Text = "Nome";
            // 
            // colTelefone1
            // 
            colTelefone1.Text = "Principal";
            // 
            // colTelefone2
            // 
            colTelefone2.Text = "Recado";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(729, 38);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(151, 49);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += button1_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(729, 129);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(151, 49);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(729, 220);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(151, 49);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(729, 311);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(151, 49);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // cpoFiltro
            // 
            cpoFiltro.Location = new Point(12, 38);
            cpoFiltro.Name = "cpoFiltro";
            cpoFiltro.Size = new Size(686, 27);
            cpoFiltro.TabIndex = 5;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(12, 15);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(46, 20);
            lblFiltro.TabIndex = 6;
            lblFiltro.Text = "Filtro:";
            lblFiltro.Click += label1_Click;
            // 
            // FormContatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 428);
            Controls.Add(lblFiltro);
            Controls.Add(cpoFiltro);
            Controls.Add(btnRestaurar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(btnPesquisar);
            Controls.Add(lstvContatos);
            MaximizeBox = false;
            Name = "FormContatos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvContatos;
        private ColumnHeader colId;
        private ColumnHeader colNome;
        private ColumnHeader colTelefone1;
        private ColumnHeader colTelefone2;
        private Button btnPesquisar;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnRestaurar;
        private MaskedTextBox cpoFiltro;
        private Label lblFiltro;
    }
}