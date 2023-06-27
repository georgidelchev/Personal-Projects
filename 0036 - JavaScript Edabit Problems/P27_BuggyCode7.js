function swap(a, b) {
    let c = a;
    a = b;
    b = c;

    return [a, b];
}

swap(100, 200);
swap(44, 33);
swap(21, 12);