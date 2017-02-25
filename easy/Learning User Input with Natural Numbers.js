process.stdin.resume();
process.stdin.setEncoding('utf8');
process.stdin.on('data', function (chunk) {
  var n = chunk;
  console.log(n++ * n * .5);
});
