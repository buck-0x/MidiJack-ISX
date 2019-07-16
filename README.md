# MidiJack ISX

**Note: Requires Unity 2019.2+**

Ports Midi input from [Keijiro](https://github.com/keijiro)'s [MidiJack package](https://github.com/keijiro/MidiJack/tree/upm) into Unity's [new Input System Package](https://github.com/Unity-Technologies/InputSystem).

Currently this only works for [Novation's Launch Control XL](https://novationmusic.com/launch/launch-control-xl) but support for more Midi devices will be added when I can get my hands on them.

### Setup

1. Download the package 
2. Go to `Edit > Project Settings... > Input System Package` and add `LaunchControlXLDevice` to `Supported Devices`
3. In an Input asset, create a new Action and select from one of the Midi controller's controls

Credit to [Gerald Orban](https://github.com/bbi-gbot) for the initial implementation.
