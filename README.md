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
https://lamfo.unb.br/wp-content/uploads/2021/03/Complexidade-Temporal-e-Espacial.pdf <br />


## Bubble Sort <br/>

O Bubble Sort é um dos algoritmos de ordenação mais simples, que consiste em percorrer os N elementos de um vetor, para cada vez percorrida, todos os elementos são comparados com o seu próximo, para verificar se estão na ordem desejada. O passe pela lista é repetido até que não seja necessário nenhuma troca, indicando que a lista está ordenada. O algoritmo recebe esse nome porque os itens menores borbulham gradualmente até o topo da lista.

Esse algoritmo não é adequado para listas grandes, pois sua complexidade é de O(n²).

![image](https://github.com/JessicaNathany/algoritmos-estrutura-dados/assets/11943572/b00bc95f-3215-4c8c-a19f-7f5d1512e720)

O Bubble Sort é mais útil para fins educacionais, pois é simples de entender e implementar. Em ambientes de produção, são preferidos algoritmos de classificação mais eficientes, como Quicksort, Heapsort ou Mergesort.

Exemplo:

![image](https://github.com/JessicaNathany/algoritmos-estrutura-dados/assets/11943572/f984b18f-a565-4144-a5ee-bc2f5047310d)

Embora o Bubble Sort não seja eficiente em muitos casos devido à sua complexidade computacional (O(n²) no pior caso), ele pode ser útil em certas situações:

1. **Tamanho pequeno da lista:** O Bubble Sort pode ser uma boa opção se a lista for relativamente pequena. Isso ocorre porque sua ineficiência é menos perceptível com listas menores.
2. **Listas quase ordenadas:** O Bubble Sort se comporta bem quando a lista já está quase ordenada, já que é capaz de detectar se a lista está ordenada rapidamente.
3. **Simplicidade:** Em termos de implementação, o Bubble Sort é bastante simples de entender e implementar. Isso pode ser útil em ambientes educacionais onde o foco é aprender os conceitos básicos de algoritmos de ordenação.
4. **Detecção de lista ordenada:** O Bubble Sort é um dos poucos algoritmos que pode confirmar que uma lista está completamente ordenada em uma única passagem.
5. **Em memória:** Como o Bubble Sort é um algoritmo de classificação in-place (ou seja, não precisa de espaço de memória extra significativo para realizar a classificação), pode ser uma escolha adequada se a memória for uma consideração.

No entanto, na maioria dos casos práticos, é aconselhável usar algoritmos de ordenação mais eficientes, como Quicksort, Mergesort ou Heapsort. Estes algoritmos têm complexidade computacional melhor e, consequentemente, lidam melhor com conjuntos de dados maiores.

Fontes: 

http://www.universidadejava.com.br/pesquisa_ordenacao/bubble-sort/
https://www.youtube.com/watch?v=GiNPe_678Ms&list=PL5TJqBvpXQv4l7nH-08fMfyl7aDFNW_fC&index=2

