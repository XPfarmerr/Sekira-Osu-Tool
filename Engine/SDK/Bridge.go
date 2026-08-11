package main

import (
    "fmt"
)

type NetworkBridge struct {
    Port int
}

func (n *NetworkBridge) Start() {
    fmt.Printf("Bridge listening on port %d\n", n.Port)
}

func main() {
    bridge := NetworkBridge{Port: 8080}
    bridge.Start()
}
