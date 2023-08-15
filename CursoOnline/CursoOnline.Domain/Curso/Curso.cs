using CursoOnline.Domain.Curso.Enums;

namespace CursoOnline.Domain.Curso
{
    public class Curso
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public decimal ValorDoCurso { get; private set; }

        public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, decimal valorDoCurso)
        {
            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.PublicoAlvo = publicoAlvo;
            this.ValorDoCurso = valorDoCurso;
        }
    }
}
