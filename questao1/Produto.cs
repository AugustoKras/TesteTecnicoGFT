namespace questao1
{
    public class Produto
    {
        protected string nome;
        protected double valor;
        protected int tipo;

        public Produto(string nome, int tipo, double valor){
            this.nome = nome;
            this.tipo = tipo;
            this.valor = valor;
        }

        public virtual double calcularValorFinal(){
            return (valor * tipo * 1.10);
        }
    }
}
