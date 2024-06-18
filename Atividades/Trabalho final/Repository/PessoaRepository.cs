using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class PessoaRepository
{
    private readonly List<Pessoa> _pessoas = new List<Pessoa>();
    private int _nextId = 1;

    public void Add(Pessoa pessoa)
    {
        pessoa.Id = _nextId++;
        _pessoas.Add(pessoa);
    }

    public void Update(Pessoa pessoa)
    {
        var existingPessoa = _pessoas.FirstOrDefault(p => p.Id == pessoa.Id);
        if (existingPessoa != null)
        {
            existingPessoa.Nome = pessoa.Nome;
            existingPessoa.Tipo = pessoa.Tipo;
        }
    }

    public Pessoa GetById(int id)
    {
        return _pessoas.FirstOrDefault(p => p.Id == id);
    }

    public List<Pessoa> GetAll()
    {
        return _pessoas;
    }

    public void Remove(int id)
    {
        var pessoa = _pessoas.FirstOrDefault(p => p.Id == id);
        if (pessoa != null)
        {
            _pessoas.Remove(pessoa);
        }
    }
}
