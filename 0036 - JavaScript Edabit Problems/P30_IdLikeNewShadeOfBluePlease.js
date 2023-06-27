function howManyWalls(n, w, h) {
    let wallSize = w * h;
    return Math.floor(n / wallSize);
}

howManyWalls(100, 4, 5);
howManyWalls(10, 15, 12);
howManyWalls(41, 3, 6);