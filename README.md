# drift-sim-traffic-mark

`drift-sim-traffic-mark` keeps a focused C# implementation around simulations. The project goal is to create a C# reference implementation for traffic workflows, centered on protocol validation, framed sample traffic, and bounds and ordering tests.

## Problem It Tries To Make Smaller

The point is to make a small domain rule concrete enough that a reader can change it and immediately see what broke.

## Drift Sim Traffic Mark Review Notes

`edge` and `stress` are the cases worth reading first. They show the optimistic and cautious ends of the fixture.

## Working Pieces

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/drift-sim-traffic-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `review cost` and `state drift`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Design Notes

The implementation keeps the scoring rule plain: reward signal and confidence, preserve slack, penalize drag, then classify the result into a review lane.

The C# addition stays small enough to inspect in one sitting.

## Example Run

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Tests

The verifier is intentionally local. It should fail if the fixture score math, lane assignment, or language-specific test drifts.

## Known Limits

No external service is required. A deeper version would add more negative cases and a clearer boundary around invalid input.
