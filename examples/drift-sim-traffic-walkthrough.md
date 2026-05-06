# Drift Sim Traffic Mark Walkthrough

This note is the quickest way to read the extra review model in `drift-sim-traffic-mark`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 136 | watch |
| stress | state drift | 120 | watch |
| edge | review cost | 221 | ship |
| recovery | decision risk | 181 | ship |
| stale | input pressure | 144 | ship |

Start with `edge` and `stress`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

The useful comparison is `review cost` against `state drift`, not the raw score alone.
