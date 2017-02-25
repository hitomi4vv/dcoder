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
  var n, _ = strconv.Atoi(sc.Text())
  fmt.Print((n + 1) * n / 2)
}
