package main
import (
  "bufio"
  "fmt"
  "os"
  "strconv"
)

func main() {
  sc := bufio.NewScanner(os.Stdin)
  sc.Scan()
  n, _ := strconv.Atoi(sc.Text())
  sum := n
  for i := 1; i < n; i++ { sum *= n - i }
  fmt.Print(sum)
}
