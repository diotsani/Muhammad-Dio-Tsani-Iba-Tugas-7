# Muhammad Dio Tsani Iba Tugas 7
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)

- Sprite Texture dioptimasi menggunakan Sprite Atlas, dapat mengurangi Batches(dari 4 menjadi 3) pada scene Main Menu.
- Audio Source disimpan kedalam list audio source, jika di play with maka audio source akan diinstantiate, jika tidak maka tidak akan memainkan audio dan game object audio source.
- Implementasi Object Poolong pada object mushroom pada scene Game, mengurangi object yang terus ter spawn pada scene game, karena dapat menyebabkan lag, karena memory dapat terus bertambah
- Optimasi dengan metode Static Batching, dapat mengurangi Batches(dari 3000+ menjadi 600+) saved by Batches
