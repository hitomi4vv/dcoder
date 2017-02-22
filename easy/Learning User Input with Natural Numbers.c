#include <stdio.h>

int main(void) {
  int i, sum = 0;
  scanf("%d", &i);
  while(i) {
    sum += i;
    i--;
  }
  printf("%d", sum);
  return 0;
}
