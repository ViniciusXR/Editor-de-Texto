namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu do Arquivo
        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            //Pergunta para o usuário se ele realmente quer sair da aplicação
            var resultadoDialog = MessageBox.Show("Você realmente deseja sair?", "Editor de texto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resultadoDialog == DialogResult.Yes)
            {
                Application.Exit();//Encerra a aplicação
            }
        }

        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            //Limpa todo o conteudo do editor de texto
            richTextConteudo.Clear();
            //Habilita a opção Salvar do menu, quando um novo arquivo é aberto
            mArquivoSalvar.Enabled = true;
            //Altera o texto da form para o nome padrão, quando é aberto um novo arquivo
            Text = Application.ProductName;
        }


        private void mArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();

            //Criar uma nova thread usando uma expressão lambda - utilizando método anônimo
            Thread t = new Thread(() => Application.Run(new Form1()));
            //Cria a nova thread no modo single-threaded
            t.SetApartmentState(ApartmentState.STA);
            //Cria uma nova instância da thread
            t.Start();
        }

        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Abrir Arquivo";
            abrir.Filter = "Rich Text File|*.rtf|Texto|*.txt|Todos|*.*";

            var resultado = abrir.ShowDialog();
            if (resultado != DialogResult.Cancel && resultado != DialogResult.Abort)
            {
                if (File.Exists(abrir.FileName))
                {
                    FileInfo arquivo = new FileInfo(abrir.FileName);
                    //Altera o texto da form, utilizando o nome do arquivo aberto
                    Text = Application.ProductName + " - " + arquivo.Name;

                    //Define o caminho completo do arquivo que será aberto
                    Gerenciador.CaminhoPasta = arquivo.DirectoryName + @"\";
                    Gerenciador.NomeArquivo = arquivo.Name.Remove(arquivo.Name.LastIndexOf("."));
                    Gerenciador.NomeExtensao = arquivo.Extension;

                    StreamReader leitor = null;

                    try
                    {
                        leitor = new StreamReader(arquivo.FullName, true);

                        //Lê todo o conteúdo do rich text na variável leitor
                        richTextConteudo.Text = leitor.ReadToEnd();


                        mArquivoSalvar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        //Exibe uma mensagem em caso de erro ao abrir o arquivo
                        MessageBox.Show("Tipo de arquivo não suportado: " + ex.Message, "Editor de texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //Fecha o objeto estava lendo o arquivo
                        leitor.Close();
                    }
                }
            }
        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.CaminhoCompleto))
            {
                //Caso o arquivo já existe, ele salva o arquivo sem perguntar
                SalvarArquivo(Gerenciador.CaminhoCompleto);
            }
            else
            {
                //Caso o arquivo não existe, será perguntado para o usuário o caminho para salvar o arquivo
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Title = "Salvando o arquivo...";
                //Filtra quais tipos de formatos que o arquivo pode ser salvo
                salvar.Filter = "Rich Text File|*.rtf|Texto|*.txt|Todos|*.*";
                salvar.CheckFileExists = false;
                salvar.CheckPathExists = true;

                var resultado = salvar.ShowDialog();
                if (resultado != DialogResult.Cancel && resultado != DialogResult.Abort)
                {
                    SalvarArquivo(salvar.FileName);
                }
            }
        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Title = "Salvar como";
            //Filtra quais tipos de formatos que o arquivo pode ser salvo
            salvar.Filter = "Rich Text File|*.rtf|Texto|*.txt|Todos|*.*";
            salvar.CheckFileExists = false;
            salvar.CheckPathExists = true;

            var resultado = salvar.ShowDialog();
            if (resultado != DialogResult.Cancel && resultado != DialogResult.Abort)
            {
                SalvarArquivo(salvar.FileName);
            }
        }

        private void SalvarArquivo(string caminhoArquivo)
        {
            //Objeto responsável por escrever o arquivo
            StreamWriter escritor = null;

            try
            {
                escritor = new StreamWriter(caminhoArquivo, false);
                //Salva o texto que está no richText(Editor de texto) 
                escritor.Write(richTextConteudo.Text);

                FileInfo arquivo = new FileInfo(caminhoArquivo);
                Gerenciador.CaminhoPasta = arquivo.DirectoryName + @"\";
                Gerenciador.NomeArquivo = arquivo.Name.Remove(arquivo.Name.LastIndexOf("."));
                Gerenciador.NomeExtensao = arquivo.Extension;

                //Altera o texto da form, utilizando o nome do arquivo salvo
                Text = Application.ProductName + " - " + arquivo.Name;

                //Desabilita a opção Salvar do menu, quando o arquivo já está salvo
                mArquivoSalvar.Enabled = false;
            }
            catch (Exception ex)
            {
                //Exibe uma mensagem em caso de erro ao salvar o arquivo
                MessageBox.Show("Erro ao salvar arquivo: " + ex.Message, "Editor de texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Fecha o objeto estava escrevendo o arquivo
                escritor.Close();
            }
        }
        private void richTextConteudo_TextChanged(object sender, EventArgs e)
        {
            //Habilita o opção Salvar no menu quando o texto é alterado
            mArquivoSalvar.Enabled = true;
        }

        #endregion

        #region Menu do Editar
        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            //Executa a operação desfazer
            richTextConteudo.Undo();
        }

        private void mEditarRefazer_Click(object sender, EventArgs e)
        {
            //Executa a operação refazer
            richTextConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            //Executa a operação recortar
            richTextConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            //Executa a operação copiar
            richTextConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            //Executa a operação colar
            richTextConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
            //Remove o texto selecionado do rich text
            richTextConteudo.Text = richTextConteudo.Text.Remove(richTextConteudo.SelectionStart, richTextConteudo.SelectedText.Length);
        }

        private void mEditarDataeHora_Click(object sender, EventArgs e)
        {
            //Executa a operação para inserir a data e hora atuais no texto 
            int index = richTextConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (richTextConteudo.SelectionStart == richTextConteudo.Text.Length)
            {
                richTextConteudo.Text = richTextConteudo.Text + dataHora;
                richTextConteudo.SelectionStart = index + dataHora.Length;
                return;
            }

            string temp = "";
            for (int i = 0; i < richTextConteudo.Text.Length; i++)
            {
                if (i == richTextConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += richTextConteudo.Text[i];
                }
                else
                {
                    temp += richTextConteudo.Text[i];
                }
            }

            //Atribui a conteúdo da variável tempo no rich text
            richTextConteudo.Text = temp;
            richTextConteudo.SelectionStart = index + dataHora.Length;
        }
        #endregion

        #region Menu do Formatar
        private void mFormatarQuebraLinha_Click(object sender, EventArgs e)
        {
            //Define a propriedade WordWrap(quebra de lina) quando selecionada pelo usuário
            richTextConteudo.WordWrap = mFormatarQuebraLinha.Checked;
        }

        private void mFormatarFonte_Click(object sender, EventArgs e)
        {
            //Exibe o FontDialog para o usuário alterar a fonte, cor e efeitos do texto
            FontDialog fonte = new FontDialog();
            fonte.ShowColor = true;
            fonte.ShowEffects = true;

            fonte.Font = richTextConteudo.Font;
            fonte.Color = richTextConteudo.ForeColor;

            var resultado = fonte.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Define a fonte, cor e efeitos selecionados no FontDialog no texto
                richTextConteudo.Font = fonte.Font;
                richTextConteudo.ForeColor = fonte.Color;
            }

        }
        #endregion

        #region Menu Exibir
        private void mExibirZoomAmpliar_Click(object sender, EventArgs e)
        {
            //Aumenta o zoom em 25% e atualiza o texto da barra de status com o novo valor
            richTextConteudo.ZoomFactor += 0.25f;
            StatusBarZoom.Text = (richTextConteudo.ZoomFactor * 100).ToString() + "%";
        }

        private void mExibirZoomReduzir_Click(object sender, EventArgs e)
        {
            //Diminui o zoom em 25% e atualiza o texto da barra de status com o novo valor
            richTextConteudo.ZoomFactor -= 0.25f;
            StatusBarZoom.Text = (richTextConteudo.ZoomFactor * 100).ToString() + "%";
        }

        private void mExibirZoomRestaurar_Click(object sender, EventArgs e)
        {
            //Restaura o zoom para o valor padrão (100%) e atualiza o texto da barra de status com o novo valor
            richTextConteudo.ZoomFactor = 1f;
            StatusBarZoom.Text = (richTextConteudo.ZoomFactor * 100).ToString() + "%";
        }

        private void mExibirBarraStatus_Click(object sender, EventArgs e)
        {
            //Deixa a barra de status visível quando a opção Barra de Status está marcada
            BarradeStatus.Visible = mExibirBarraStatus.Checked;
        }
        #endregion

        #region Menu Ajuda
        private void mAjudaSobrePC_Click(object sender, EventArgs e)
        {
            //Exibe uma nova Form com as informações sobre o computador
            FormSobrePC f = new FormSobrePC();
            f.ShowDialog();
        }

        private void mAjudaSobre_Click(object sender, EventArgs e)
        {
            //Exibe informações sobre o aplicativo em uma nova form
            FormSobre f = new FormSobre();
            f.ShowDialog();
        }
        #endregion

    }
}