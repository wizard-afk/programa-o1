using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class PessoaController
{
    private readonly PessoaRepository _pessoaRepository = new PessoaRepository();

    public void CadastrarPessoa(Pessoa pessoa)
    {
        _pessoaRepository.Add(pessoa);
    }

    public void AtualizarPessoa(Pessoa pessoa)
    {
        _pessoaRepository.Update(pessoa);
    }

    public Pessoa BuscarPessoaPorId(int id)
    {
        return _pessoaRepository.GetById(id);
    }

    public List<Pessoa> ListarPessoas()
    {
        return _pessoaRepository.GetAll();
    }

    public void RemoverPessoa(int id)
    {
        _pessoaRepository.Remove(id);
    }
}
