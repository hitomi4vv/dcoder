#include <iostream>
using namespace std;

int main() {
  int i, sum = 0;
  cin >> i;
  do { sum += i; } while(i--);
  cout << sum << endl;
  return 0;
}
