This interview Q is based on https://adventofcode.com/2021/day/14 

Part 1:
- Get candidate to create a working version that will work up to step 10

Expect candidate to recognise:
- initial string working is a hack
- need to input the table in some manner
- if using a string method (which would be fine in part 1) a string builder would be better

---

Part 2:
- Refactor (if needed after Part 1) to allow it to work up to (and beyond?) 40 interations
- If needed, remind candidate that we aren't interested in what the final string looks like

Expect candidate to recognise:
- If Part 1 was string method - doing high value of growth steps will break string length limits (~28th interation) and be very slow as it grows
- Unit tests to ensure the refactoring doesn't break Part 1 work