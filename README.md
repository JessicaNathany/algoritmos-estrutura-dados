# Estrutura de Dados com a linguagem <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> 

Este é repositório de estudos sobre estrutura de dados utilizando a linguagem C#.<br/>

 <h4 align="center"> 
	🚧  Project 🚀 em construção...  🚧
 </h4>

## Documentação 📝<br/>

- Introdução e Referências
- Big-O
- Bubble Sort
- Selection Sort
- Insertion Sort
- Quick Sort
- Merge Sort
- Arrays, Listas e Vetores <br/>

 ## Estrutura de Dados 🧮

Para estudar estrutura de dados, sugiro o seguinte roteiro de estudos:<br/>

Fundamentos de programação: Antes de começar a estudar estrutura de dados, é importante ter uma sólida compreensão dos conceitos fundamentais de programação,
como variáveis, funções, loops, condicionais, etc. Se você não tem experiência com programação, comece com cursos básicos de programação em uma linguagem popular, 
como Python, Java ou C++. Há muitos cursos online gratuitos e pagos disponíveis. <br/>

## Notação Big-O <br/>

A notação O (Big O) é uma notação matemática utilizada para medir a eficiência e desempenho do algoritmo de forma simples e prática. <br/>
Ela é usada para descrever o limite superior do número de operações que um algoritmo realiza em função do tamanho de entrada. Por exemplo, se um algoritmo tem uma complexidade O (n), isso significa que o número de operações cresce linearmente com o tamanho de entrada.

![image](https://github.com/JessicaNathany/algoritmos-estrutura-dados/assets/11943572/c368e547-e619-4e75-9e37-c6c39a86ac37)


Observa-se no gráfico acima, a diferença no tempo de processamento (eixo Y) conforme a quantidade de dados de entrada aumenta (eixo X).<br/>

****Como implementar a notação O grande baseando-se no algoritmo?****

Considere o seguinte algoritmo:


```
function calcular() {
    return 15 * (30 + 90);
}

print(calcular());

```
O exemplo de algoritmo acima apenas realiza um pequeno cálculo. No caso acima, não há repetições, portanto o tempo de demora é representado como O(1).

### **Como calcular repetições dentro do algoritmo?**

Ao utilizarmos loops dentro do algoritmo o resultado pode variar um pouco:

```
functioncalcular(int $no) {
return 15 * ($no + 90);
}

foreach ($i = 0; $i < 1000; i++) {
print(calcular($i));
}

```

**Referências**: 

https://algol.dev/notacao-big-o/
https://blog.pantuza.com/artigos/a-notacao-o
https://dicionariotec.com/posts/notacao-do-big-o
https://dicionariotec.com/posts/pilha-stack-e-fila-queue
https://www.bigocheatsheet.com/
[https://estevestoni.medium.com/iniciando-com-a-notação-big-o-be996fa3b47b](https://estevestoni.medium.com/iniciando-com-a-nota%C3%A7%C3%A3o-big-o-be996fa3b47b)
https://lamfo.unb.br/wp-content/uploads/2021/03/Complexidade-Temporal-e-Espacial.pdf

## Bubble Sort <br/>
