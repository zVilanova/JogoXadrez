# ♟️ Jogo de Xadrez — Aplicação de Console

Um jogo de xadrez totalmente funcional construído em C#, desenvolvido como um estudo prático de Programação Orientada a Objetos (POO). A aplicação simula uma partida completa entre dois jogadores diretamente no terminal, aplicando as regras oficiais do xadrez do início ao fim.

Este projeto foi construído para aprofundar meu entendimento sobre modelagem de objetos, lógica de programação e como projetar sistemas governados por regras complexas e interdependentes.

## Objetivos

- Aplicar conceitos fundamentais de Programação Orientada a Objetos em um domínio não trivial
- Fortalecer habilidades de resolução de problemas e raciocínio lógico
- Modelar um sistema do mundo real com regras e estados em camadas
- Praticar a tradução de requisitos complexos em código limpo e sustentável

## Como Funciona

O jogo roda inteiramente no console, com dois jogadores alternando turnos em um tabuleiro completo de 8x8.

**Mecânicas principais:**
- Representação completa do tabuleiro com todas as peças de xadrez padrão
- Lógica de movimento individual para cada tipo de peça
- Jogabilidade baseada em turnos (Brancas vs. Pretas)
- Validação de movimentos legais — apenas movimentos válidos podem ser executados
- Detecção de xeque e xeque-mate

**Movimentos especiais suportados:**
- Roque
- En passant
- Promoção de peão

Cada partida é regida pelas regras oficiais do xadrez, garantindo uma experiência de jogo fiel e consistente.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Paradigma:** Programação Orientada a Objetos
- **Interface:** Console / Terminal

## Primeiros Passos

1. Clone o repositório:
```bash
   git clone https://github.com/zVilanova/JogoXadrez.git
