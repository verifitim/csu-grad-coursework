# Team 4 — My Profile

CIS 675 interactive prototype covering US2 (show abilities beyond expected credentials) and US7 (maintain profile and resume).

The product interface intentionally presents the proposed finished experience. All starting candidate data is fictional. This single HTML file uses browser-local state and has no backend or real AI service.

## Included

- Editable profile, work experience, education, and certifications.
- Resume attachment interaction within the profile section. The prototype validates extension and size and remembers only the filename; no document bytes are uploaded, stored, parsed, or shared with employers.
- Suggested skills with supporting experience, transfer context where available, and confirm/edit/dismiss controls.
- An accomplishment input that illustrates discovery through a small set of keyword rules. It is not a real skill assessment or general-purpose language model.
- Manual skill entry and candidate review.

## Outside this version

Automatic resume parsing and profile population, employer evaluation configuration, verified credentials, employer access, authentication, and server-side persistence are not implemented. Resume-based profile population remains a proposed backlog item rather than an interface promise.

## Validation

JavaScript syntax and referenced element IDs were checked. A browser execution environment was unavailable for visual or end-to-end testing.
