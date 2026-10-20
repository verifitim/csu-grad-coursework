# CIS 675 page conventions

- Every product page must include the top-right `I'm a` role selector and `Go to` page selector, on desktop and mobile.
- Job seeker home: `my-profile/index.html`. Hiring manager home: `job-posting/index.html`.
- When adding a page, register its label and relative URL under the relevant role in the `personaPages` map on EVERY existing page, including the new page. Keep these maps identical. Inspect all CIS 675 page HTML files, not just the home pages.
- Selecting a role opens that role's home. Selecting a page opens that page. On any page, show its actual role and page as selected; handle browser Back/Forward restoration.
- Before completing a new page, verify every registered URL exists and each persona's page selector includes all of its pages.
- Keep product UI realistic: prototype disclosures and implementation details belong in README files. The prototype uses fictional data and browser-local interactions.
- Ground each design in the Part 1 introduction and relevant user story. Emphasize recognizing both conventional qualifications and overlooked transferable abilities.
