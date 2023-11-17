namespace AgendaTelefonica.Frontend
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            toolMenu = new ToolStrip();
            menuCadastros = new ToolStripDropDownButton();
            mnuCadContatos = new ToolStripMenuItem();
            toolMenu.SuspendLayout();
            SuspendLayout();
            // 
            // toolMenu
            // 
            toolMenu.ImageScalingSize = new Size(20, 20);
            toolMenu.Items.AddRange(new ToolStripItem[] { menuCadastros });
            toolMenu.Location = new Point(0, 0);
            toolMenu.Name = "toolMenu";
            toolMenu.Size = new Size(800, 27);
            toolMenu.TabIndex = 0;
            toolMenu.Text = "toolStrip1";
            // 
            // menuCadastros
            // 
            menuCadastros.DisplayStyle = ToolStripItemDisplayStyle.Text;
            menuCadastros.DropDownItems.AddRange(new ToolStripItem[] { mnuCadContatos });
            menuCadastros.Image = (Image)resources.GetObject("menuCadastros.Image");
            menuCadastros.ImageTransparentColor = Color.Magenta;
            menuCadastros.Name = "menuCadastros";
            menuCadastros.Size = new Size(88, 24);
            menuCadastros.Text = "Cadastros";
            // 
            // mnuCadContatos
            // 
            mnuCadContatos.Name = "mnuCadContatos";
            mnuCadContatos.Size = new Size(224, 26);
            mnuCadContatos.Text = "Contatos";
            mnuCadContatos.Click += contatosToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(toolMenu);
            IsMdiContainer = true;
            Name = "FormMenu";
            Text = "Agenda Telefônica";
            WindowState = FormWindowState.Maximized;
            toolMenu.ResumeLayout(false);
            toolMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolMenu;
        private ToolStripDropDownButton menuCadastros;
        private ToolStripMenuItem mnuCadContatos;
    }
}