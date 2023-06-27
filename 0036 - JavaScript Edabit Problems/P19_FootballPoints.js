function footballPoints(wins, draws, losses) {
    let winPoints = wins * 3;

    return winPoints + draws;
}

footballPoints(3, 4, 2);