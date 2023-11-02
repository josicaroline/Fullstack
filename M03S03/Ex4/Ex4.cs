using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    /* O princípio da segregação de interface solicita que haja uma separação de 
    interfaces, de forma que muitas interfaces específicas do cliente são melhores 
    que uma interface de propósito geral, a fim de os clientes não implementarem 
    uma função que não necessitem. */ 


/* 
    Exemplo:


public interface Locadora {
	void alugarFilme();
	void devolverFilme();
	void getEstoque();
	double calcularTaxa(Filme filme);
	void pagamento(Filme filme);
}

Class Filme { }


public class FilmeGratuito implements Locadora {
	public void alugarFilme() { }
	public void devolverFilme() { }
	public void getEstoque() { }
	public double calcularTaxa(Filme filme) {return 0;}
	public void pagamento(Filme filme) {throw new Exception(“Filme gratuito”);}
}


//separando pelo princípio da segregação: (exemplos nos outros arquivos da pasta)

*/
