using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HelloWorld13._2
{
    // Ordem de sintaxe: 
    // Atributos privados, Linha 22.
    // Properties autoimplementadas, Ex: Linhas 23 e 24.
    // Construtores, Ex: Linhas 26 - 33.
    // Properties customizadas, Ex: Linhas 36 - 47.
    // Outros métodos da classe, Ex: Linhas 50 - 72.

    class Produto
    {
        // Auto properties:
        // É uma forma simplificada de se declarar properties que não necessitam de lógicas particulares para as operações get e set.

        private string _nome; // '_nome' tem uma lógica particular no método 'set', logo não é possível usar auto propertie
        public int Quantidade { get; private set; } // declarando dessa forma elimina a criacão de um método get para propertie
        public double Preco { get; private set; } // digitar: 'prop' + 2x'tab'  é uma atalho pra criar automatico a auto propertie

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto() { } // Sobrecarga para funcionar o construtor padrão e sintaxe alternativa (Só é necessário quando se declara algum construtor)

        // Properties:
        public string Nome // Em vez de chamar o método get/set direto em outra classe para privar os atributos, usa-se a propertie para simplificar a sintaxe, como se fosse um atributo.
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }
        }


        public double ValorTotalEmEsqtoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString() // método usado para retornar a váriavel 'p1' nas informações em String
        {
            return _nome + ", R$:" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " " +
                "Unidades, total R$:" + ValorTotalEmEsqtoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

