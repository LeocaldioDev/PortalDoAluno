using PortalDoAluno.Infrastrutura;

namespace PortalDoAluno
{
    public partial class Form1 : Form
    {

        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
            ObterAlunos();
        }

        private void ObterAlunos()
        {
            var repository = new AlunoRepository();
           Alunos = repository.GetAll();

            foreach (var item in Alunos)
            {
                lv__alunos.Items.Add(new ListViewItem(new string[] {
                item.nome.ToString(),
                item.idade.ToString(),
                item.curso.ToString(),
                
                }));
            }

        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = tb_nome.Text;
                var idade = tb_idade.Text;
                var curso = tb_curso.Text;

                foreach (var item in Alunos)
                {
                    if (item.nome == nome.ToString()) {

                        MessageBox.Show(nome + " Ja existe no sistema");
                        return;

                    }

                }

                var aluno = new Aluno(nome.ToString(),idade.ToString(),curso.ToString());
                Alunos.Add(aluno);

                var repository = new AlunoRepository();
                repository.Add(aluno);

                lv__alunos.Items.Add(new ListViewItem(new string[]
                {
                    nome.ToString(),
                    idade.ToString(),
                    curso.ToString()
                }));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
