using Xunit;
using CursoOnline.Domain.Curso;
using CursoOnline.Domain.Curso.Enums;

namespace CursoOnline.Domain.Test.Cursos
{
    public class CursoTest
    {
        // Criar um curso com os seguintes dados:
        // Nome, Carga Horária, público alvo e valor do Curso

        [Fact]
        public void Curso_CriarCurso_RetornaCurso()
        {
            var CursoEsperado = new
            {
                Nome = "Curso de TDD",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorDoCurso = (decimal)100
            };

            var curso = new Curso.Curso(CursoEsperado.Nome, CursoEsperado.CargaHoraria, CursoEsperado.PublicoAlvo, CursoEsperado.ValorDoCurso);

            Assert.Equal(CursoEsperado.Nome, curso.Nome);
        }
    }
}
