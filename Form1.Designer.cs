namespace Editor_de_Texto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarradeMenu = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarDataeHora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirBarraStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobrePC = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.BarradeStatus = new System.Windows.Forms.StatusStrip();
            this.StatusBarZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBarNovo = new System.Windows.Forms.ToolStripButton();
            this.toolBarAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolBarSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarFonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarZoomMais = new System.Windows.Forms.ToolStripButton();
            this.toolBarZoomMenos = new System.Windows.Forms.ToolStripButton();
            this.toolBarZoom = new System.Windows.Forms.ToolStripButton();
            this.richTextConteudo = new System.Windows.Forms.RichTextBox();
            this.BarradeMenu.SuspendLayout();
            this.BarradeStatus.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarradeMenu
            // 
            this.BarradeMenu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BarradeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarradeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.BarradeMenu.Location = new System.Drawing.Point(0, 0);
            this.BarradeMenu.Name = "BarradeMenu";
            this.BarradeMenu.Size = new System.Drawing.Size(1038, 29);
            this.BarradeMenu.TabIndex = 0;
            this.BarradeMenu.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivoNovaJanela,
            this.toolStripSeparator1,
            this.mArquivoAbrir,
            this.mArquivoSalvar,
            this.mArquivoSalvarComo,
            this.toolStripSeparator2,
            this.mArquivoSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(79, 25);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Image = global::Editor_de_Texto.Properties.Resources.documento;
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mArquivoNovo.Size = new System.Drawing.Size(281, 26);
            this.mArquivoNovo.Text = "Novo";
            this.mArquivoNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // mArquivoNovaJanela
            // 
            this.mArquivoNovaJanela.Image = global::Editor_de_Texto.Properties.Resources.documento;
            this.mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            this.mArquivoNovaJanela.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mArquivoNovaJanela.Size = new System.Drawing.Size(281, 26);
            this.mArquivoNovaJanela.Text = "Nova Janela";
            this.mArquivoNovaJanela.Click += new System.EventHandler(this.mArquivoNovaJanela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(278, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Image = global::Editor_de_Texto.Properties.Resources.open_folder;
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mArquivoAbrir.Size = new System.Drawing.Size(281, 26);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalvar
            // 
            this.mArquivoSalvar.Image = global::Editor_de_Texto.Properties.Resources.diskette;
            this.mArquivoSalvar.Name = "mArquivoSalvar";
            this.mArquivoSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvar.Size = new System.Drawing.Size(281, 26);
            this.mArquivoSalvar.Text = "Salvar";
            this.mArquivoSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // mArquivoSalvarComo
            // 
            this.mArquivoSalvarComo.Image = global::Editor_de_Texto.Properties.Resources.diskette;
            this.mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            this.mArquivoSalvarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvarComo.Size = new System.Drawing.Size(281, 26);
            this.mArquivoSalvarComo.Text = "Salvar Como";
            this.mArquivoSalvarComo.Click += new System.EventHandler(this.mArquivoSalvarComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(278, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Image = global::Editor_de_Texto.Properties.Resources.sair_96;
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mArquivoSair.Size = new System.Drawing.Size(281, 26);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRefazer,
            this.toolStripSeparator3,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator4,
            this.mEditarDataeHora});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(64, 25);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Image = global::Editor_de_Texto.Properties.Resources.undo_circular_arrow;
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditarDesfazer.Size = new System.Drawing.Size(209, 26);
            this.mEditarDesfazer.Text = "Desfazer";
            this.mEditarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // mEditarRefazer
            // 
            this.mEditarRefazer.Image = global::Editor_de_Texto.Properties.Resources.redo_arrow_symbol;
            this.mEditarRefazer.Name = "mEditarRefazer";
            this.mEditarRefazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mEditarRefazer.Size = new System.Drawing.Size(209, 26);
            this.mEditarRefazer.Text = "Refazer";
            this.mEditarRefazer.Click += new System.EventHandler(this.mEditarRefazer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Image = global::Editor_de_Texto.Properties.Resources.scissors;
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditarRecortar.Size = new System.Drawing.Size(209, 26);
            this.mEditarRecortar.Text = "Recortar";
            this.mEditarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Image = global::Editor_de_Texto.Properties.Resources.files;
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditarCopiar.Size = new System.Drawing.Size(209, 26);
            this.mEditarCopiar.Text = "Copiar";
            this.mEditarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // mEditarColar
            // 
            this.mEditarColar.Image = global::Editor_de_Texto.Properties.Resources.paste;
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditarColar.Size = new System.Drawing.Size(209, 26);
            this.mEditarColar.Text = "Colar";
            this.mEditarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Image = global::Editor_de_Texto.Properties.Resources.icons8_remove_96;
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.ShortcutKeyDisplayString = "Delete";
            this.mEditarExcluir.Size = new System.Drawing.Size(209, 26);
            this.mEditarExcluir.Text = "Excluir";
            this.mEditarExcluir.Click += new System.EventHandler(this.mEditarExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // mEditarDataeHora
            // 
            this.mEditarDataeHora.Image = global::Editor_de_Texto.Properties.Resources.icons8_calendar_53;
            this.mEditarDataeHora.Name = "mEditarDataeHora";
            this.mEditarDataeHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditarDataeHora.Size = new System.Drawing.Size(209, 26);
            this.mEditarDataeHora.Text = "Data e Hora";
            this.mEditarDataeHora.Click += new System.EventHandler(this.mEditarDataeHora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebraLinha,
            this.mFormatarFonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(88, 25);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraLinha
            // 
            this.mFormatarQuebraLinha.CheckOnClick = true;
            this.mFormatarQuebraLinha.Image = global::Editor_de_Texto.Properties.Resources.icons8_word_wrap_50;
            this.mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
            this.mFormatarQuebraLinha.Size = new System.Drawing.Size(286, 26);
            this.mFormatarQuebraLinha.Text = "Quebra automática de linha";
            this.mFormatarQuebraLinha.Click += new System.EventHandler(this.mFormatarQuebraLinha_Click);
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Image = global::Editor_de_Texto.Properties.Resources.icons8_font_64;
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(286, 26);
            this.mFormatarFonte.Text = "Fonte";
            this.mFormatarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.mExibirBarraStatus});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(62, 25);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoomAmpliar,
            this.mExibirZoomReduzir,
            this.mExibirZoomRestaurar});
            this.mExibirZoom.Image = global::Editor_de_Texto.Properties.Resources.icons8_zoom_64;
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.Size = new System.Drawing.Size(198, 26);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            this.mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            this.mExibirZoomAmpliar.ShortcutKeyDisplayString = "Ctrl + +";
            this.mExibirZoomAmpliar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mExibirZoomAmpliar.Size = new System.Drawing.Size(216, 26);
            this.mExibirZoomAmpliar.Text = "Ampliar";
            this.mExibirZoomAmpliar.Click += new System.EventHandler(this.mExibirZoomAmpliar_Click);
            // 
            // mExibirZoomReduzir
            // 
            this.mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            this.mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl + -";
            this.mExibirZoomReduzir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mExibirZoomReduzir.Size = new System.Drawing.Size(216, 26);
            this.mExibirZoomReduzir.Text = "Reduzir";
            this.mExibirZoomReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // mExibirZoomRestaurar
            // 
            this.mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            this.mExibirZoomRestaurar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mExibirZoomRestaurar.Size = new System.Drawing.Size(216, 26);
            this.mExibirZoomRestaurar.Text = "Restaurar";
            this.mExibirZoomRestaurar.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // mExibirBarraStatus
            // 
            this.mExibirBarraStatus.Checked = true;
            this.mExibirBarraStatus.CheckOnClick = true;
            this.mExibirBarraStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirBarraStatus.Name = "mExibirBarraStatus";
            this.mExibirBarraStatus.Size = new System.Drawing.Size(198, 26);
            this.mExibirBarraStatus.Text = "Barra de Status";
            this.mExibirBarraStatus.Click += new System.EventHandler(this.mExibirBarraStatus_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaSobrePC,
            this.mAjudaSobre});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(64, 25);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaSobrePC
            // 
            this.mAjudaSobrePC.Image = global::Editor_de_Texto.Properties.Resources.ponto_de_interrogação_64;
            this.mAjudaSobrePC.Name = "mAjudaSobrePC";
            this.mAjudaSobrePC.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAjudaSobrePC.Size = new System.Drawing.Size(267, 26);
            this.mAjudaSobrePC.Text = "Sobre o Computador";
            this.mAjudaSobrePC.Click += new System.EventHandler(this.mAjudaSobrePC_Click);
            // 
            // mAjudaSobre
            // 
            this.mAjudaSobre.Image = global::Editor_de_Texto.Properties.Resources.sobre_48;
            this.mAjudaSobre.Name = "mAjudaSobre";
            this.mAjudaSobre.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mAjudaSobre.Size = new System.Drawing.Size(267, 26);
            this.mAjudaSobre.Text = "Sobre";
            this.mAjudaSobre.Click += new System.EventHandler(this.mAjudaSobre_Click);
            // 
            // BarradeStatus
            // 
            this.BarradeStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarradeStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarZoom});
            this.BarradeStatus.Location = new System.Drawing.Point(0, 521);
            this.BarradeStatus.Name = "BarradeStatus";
            this.BarradeStatus.Size = new System.Drawing.Size(1038, 26);
            this.BarradeStatus.TabIndex = 1;
            this.BarradeStatus.Text = "statusStrip1";
            // 
            // StatusBarZoom
            // 
            this.StatusBarZoom.Name = "StatusBarZoom";
            this.StatusBarZoom.Size = new System.Drawing.Size(45, 20);
            this.StatusBarZoom.Text = "100%";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarNovo,
            this.toolBarAbrir,
            this.toolBarSalvar,
            this.toolStripSeparator5,
            this.toolBarFonte,
            this.toolStripSeparator6,
            this.toolBarZoomMais,
            this.toolBarZoomMenos,
            this.toolBarZoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1038, 30);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBarNovo
            // 
            this.toolBarNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarNovo.Image = global::Editor_de_Texto.Properties.Resources.documento;
            this.toolBarNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarNovo.Name = "toolBarNovo";
            this.toolBarNovo.Size = new System.Drawing.Size(29, 27);
            this.toolBarNovo.Text = "toolStripButton1";
            this.toolBarNovo.ToolTipText = "Novo";
            this.toolBarNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // toolBarAbrir
            // 
            this.toolBarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarAbrir.Image = global::Editor_de_Texto.Properties.Resources.open_folder;
            this.toolBarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarAbrir.Name = "toolBarAbrir";
            this.toolBarAbrir.Size = new System.Drawing.Size(29, 27);
            this.toolBarAbrir.Text = "toolStripButton2";
            this.toolBarAbrir.ToolTipText = "Abrir";
            this.toolBarAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // toolBarSalvar
            // 
            this.toolBarSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarSalvar.Image = global::Editor_de_Texto.Properties.Resources.diskette;
            this.toolBarSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarSalvar.Name = "toolBarSalvar";
            this.toolBarSalvar.Size = new System.Drawing.Size(29, 27);
            this.toolBarSalvar.Text = "toolStripButton3";
            this.toolBarSalvar.ToolTipText = "Salvar";
            this.toolBarSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 30);
            // 
            // toolBarFonte
            // 
            this.toolBarFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBarFonte.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarFonte.Image = global::Editor_de_Texto.Properties.Resources.icons8_font_64;
            this.toolBarFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarFonte.Name = "toolBarFonte";
            this.toolBarFonte.Size = new System.Drawing.Size(29, 27);
            this.toolBarFonte.Text = "A";
            this.toolBarFonte.ToolTipText = "Formatar Fonte";
            this.toolBarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 30);
            // 
            // toolBarZoomMais
            // 
            this.toolBarZoomMais.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarZoomMais.Image = global::Editor_de_Texto.Properties.Resources.icons8_zoom_64;
            this.toolBarZoomMais.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoomMais.Name = "toolBarZoomMais";
            this.toolBarZoomMais.Size = new System.Drawing.Size(46, 27);
            this.toolBarZoomMais.Text = "+";
            this.toolBarZoomMais.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolBarZoomMais.ToolTipText = "Aumentar Zoom";
            this.toolBarZoomMais.Click += new System.EventHandler(this.mExibirZoomAmpliar_Click);
            // 
            // toolBarZoomMenos
            // 
            this.toolBarZoomMenos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarZoomMenos.Image = global::Editor_de_Texto.Properties.Resources.icons8_zoom_64;
            this.toolBarZoomMenos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoomMenos.Name = "toolBarZoomMenos";
            this.toolBarZoomMenos.Size = new System.Drawing.Size(41, 27);
            this.toolBarZoomMenos.Text = "-";
            this.toolBarZoomMenos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolBarZoomMenos.ToolTipText = "Diminuir Zoom";
            this.toolBarZoomMenos.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // toolBarZoom
            // 
            this.toolBarZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarZoom.Image = global::Editor_de_Texto.Properties.Resources.icons8_zoom_64;
            this.toolBarZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoom.Name = "toolBarZoom";
            this.toolBarZoom.Size = new System.Drawing.Size(29, 27);
            this.toolBarZoom.Text = "toolStripButton9";
            this.toolBarZoom.ToolTipText = "Zoom Padrão 100%";
            this.toolBarZoom.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // richTextConteudo
            // 
            this.richTextConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextConteudo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextConteudo.Location = new System.Drawing.Point(0, 59);
            this.richTextConteudo.Name = "richTextConteudo";
            this.richTextConteudo.Size = new System.Drawing.Size(1038, 462);
            this.richTextConteudo.TabIndex = 3;
            this.richTextConteudo.Text = "";
            this.richTextConteudo.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 547);
            this.Controls.Add(this.richTextConteudo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BarradeStatus);
            this.Controls.Add(this.BarradeMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.BarradeMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.BarradeMenu.ResumeLayout(false);
            this.BarradeMenu.PerformLayout();
            this.BarradeStatus.ResumeLayout(false);
            this.BarradeStatus.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip BarradeMenu;
        private ToolStripMenuItem mArquivo;
        private ToolStripMenuItem mEditar;
        private ToolStripMenuItem mFormatar;
        private ToolStripMenuItem mExibir;
        private ToolStripMenuItem mAjuda;
        private ToolStripMenuItem mArquivoNovo;
        private ToolStripMenuItem mArquivoNovaJanela;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mArquivoAbrir;
        private ToolStripMenuItem mArquivoSalvar;
        private ToolStripMenuItem mArquivoSalvarComo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mArquivoSair;
        private ToolStripMenuItem mEditarDesfazer;
        private ToolStripMenuItem mEditarRefazer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditarRecortar;
        private ToolStripMenuItem mEditarCopiar;
        private ToolStripMenuItem mEditarColar;
        private ToolStripMenuItem mEditarExcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mEditarDataeHora;
        private ToolStripMenuItem mFormatarQuebraLinha;
        private ToolStripMenuItem mFormatarFonte;
        private ToolStripMenuItem mExibirZoom;
        private ToolStripMenuItem mExibirZoomAmpliar;
        private ToolStripMenuItem mExibirZoomReduzir;
        private ToolStripMenuItem mExibirZoomRestaurar;
        private ToolStripMenuItem mExibirBarraStatus;
        private ToolStripMenuItem mAjudaSobrePC;
        private ToolStripMenuItem mAjudaSobre;
        private StatusStrip BarradeStatus;
        private ToolStripStatusLabel StatusBarZoom;
        private ToolStrip toolStrip1;
        private RichTextBox richTextConteudo;
        private ToolStripButton toolBarNovo;
        private ToolStripButton toolBarAbrir;
        private ToolStripButton toolBarSalvar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolBarFonte;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolBarZoomMais;
        private ToolStripButton toolBarZoomMenos;
        private ToolStripButton toolBarZoom;
    }
}