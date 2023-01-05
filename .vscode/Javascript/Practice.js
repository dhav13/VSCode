let a = { p: 10, q: 20 }
console.log(a.p);

let b = Object.create(a);
let c = Object.create(b);
console.log(b.p);

b.p = 20;
a.q = 30;
console.log(b.p + " " + b.q);

console.log(a.isPrototypeOf(b));
console.log(b.isPrototypeOf(c));