using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BibliotecaController
{
    private readonly BibliotecaRepository _bibliotecaRepository = new BibliotecaRepository();

    public void AdicionarBiblioteca(Biblioteca biblioteca)
    {
        _bibliotecaRepository.Add(biblioteca);
    }

    public void AtualizarBiblioteca(Biblioteca biblioteca)
    {
        _bibliotecaRepository.Update(biblioteca);
    }

    public Biblioteca BuscarBibliotecaPorId(int id)
    {
        return _bibliotecaRepository.GetById(id);
    }

    public List<Biblioteca> ListarBibliotecas()
    {
        return _bibliotecaRepository.GetAll();
    }

    public void RemoverBiblioteca(int id)
    {
        _bibliotecaRepository.Remove(id);
    }
}
