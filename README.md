# Unity GPU Instancing

This is a demonstration of doing GPU instancing (AKA mesh instancing, geometry
instancing) and it's performance implications.

*NOTE: if you wish to try this out, there needs to be a GPU bottleneck to see a
performance uplift. Unfortunately, Unity has a significant CPU overhead in the
editor, so if you don't see a difference, try an exported version.*

## How to Use in Your Own Project

Unity luckily makes this quite easy. It simply involves checking a box in the
material's inspector menu:

![](./pictures/howtoenable.png)

Now, if there are several very similar objects that share this material, Unity
will attempt to draw as many of them as possible in the same call.

## Checking it is Working

When running the demo (or your game) in the editor, clicking the bug icon at
the top will bring out the frame debugger.

![](./pictures/debug.png)

If the relevant objects are labeled with "(instanced)", then GPU instancing is
enabled and working for those objects.

## When to Use

Instancing is most useful when you have many objects (in the hundreds of
objects) that are not simple (in the hundreds of vertices). Things you might
have in this niche might include:

- Foliage (trees, bushes)
- Buildings
- NPC's (enemy swarms, crowds)
- Certain particle effects
- Asteroids
- etc.
