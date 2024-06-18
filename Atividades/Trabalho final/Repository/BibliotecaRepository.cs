using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BibliotecaRepository
{
    private readonly List<Biblioteca> _bibliotecas = new List<Biblioteca>();
    private int _nextId = 1;

    public void Add(Biblioteca biblioteca)
    {
        biblioteca.Id = _nextId++;
        _bibliotecas.Add(biblioteca);
    }

    public void Update(Biblioteca biblioteca)
    {
        var existingBiblioteca = _bibliotecas.FirstOrDefault(b => b.Id == biblioteca.Id);
        if (existingBiblioteca != null)
        {
            existingBiblioteca.Nome = biblioteca.Nome;
            existingBiblioteca.Endereco = biblioteca.Endereco;
            existingBiblioteca.Livros = biblioteca.Livros;
        }
    }

    public Biblioteca GetById(int id)
    {
        return _bibliotecas.FirstOrDefault(b => b.Id == id);
    }

    public List<Biblioteca> GetAll()
    {
        return _bibliotecas;
    }

    public void Remove(int id)
    {
        var biblioteca = _bibliotecas.FirstOrDefault(b => b.Id == id);
        if (biblioteca != null)
        {
            _bibliotecas.Remove(biblioteca);
        }
    }
}
