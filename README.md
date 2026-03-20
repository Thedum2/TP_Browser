# TPBrowser

브라우저 엔진의 기본 구조를 직접 만들면서 학습하기 위한 C# 미니 프로젝트입니다.
실사용 브라우저를 목표로 하지 않고, 작은 단계로 나누어 핵심 개념을 익히는 데 집중합니다.

## 목표

- 브라우저가 어떤 계층으로 나뉘는지 이해한다.
- HTML 파싱, 스타일 해석, 레이아웃, 페인트를 직접 구현해 본다.
- 처음부터 완성형을 만들기보다, 작고 읽기 쉬운 기준선을 단계적으로 확장한다.

## 현재 상태

현재 저장소는 구현을 비우고, 학습용으로 다시 쌓아 올릴 수 있도록 솔루션/프로젝트/폴더 구조만 남긴 상태입니다.

## 솔루션 구조

- `TPBrowser.sln`
- `TPBrowser.Host.WinForms`
- `TPBrowser.Core`
- `TPBrowser.Parser`
- `TPBrowser.Style`
- `TPBrowser.Render`
- `TPBrowser.Tests`

## 프로젝트 역할

### `TPBrowser.Host.WinForms`

- WinForms 호스트
- 애플리케이션 시작점 보유
- 향후 그리기 표면, repaint, resize, 입력 연결 담당
- 엔진 로직은 최대한 넣지 않음

### `TPBrowser.Core`

- 공통 타입과 기초 개념
- geometry, styling, enum, helper 등 배치
- 다른 상위 프로젝트에 의존하지 않는 기반 계층

### `TPBrowser.Parser`

- HTML / CSS 파싱 계층
- `Html`, `Css` 폴더 기준으로 분리
- 제한적인 parser부터 작게 시작

### `TPBrowser.Style`

- 스타일 해석 계층
- DOM 유사 구조와 CSS 규칙을 바탕으로 computed style 생성

### `TPBrowser.Render`

- layout / paint 계층
- `Layout`, `Paint` 폴더 기준으로 분리
- 실제 그리기 전에 paint command 같은 중간 표현을 만드는 방향 유지

### `TPBrowser.Tests`

- xUnit 테스트
- 값 타입, parser, layout 규칙 등 학습 단계별 기준선 검증

## 참조 방향

- `TPBrowser.Parser -> TPBrowser.Core`
- `TPBrowser.Style -> TPBrowser.Core, TPBrowser.Parser`
- `TPBrowser.Render -> TPBrowser.Core, TPBrowser.Style, TPBrowser.Parser`
- `TPBrowser.Host.WinForms -> TPBrowser.Core, TPBrowser.Parser, TPBrowser.Style, TPBrowser.Render`
- `TPBrowser.Tests -> 필요한 프로젝트 참조`

## 방향성

이 프로젝트는 처음부터 많은 기능을 넣기보다, 아래 순서로 천천히 쌓는 것을 전제로 합니다.

1. `Core`에 geometry와 공통 타입 추가
2. `Parser`에 최소 HTML / CSS parser 추가
3. `Style`에 computed style 해석 추가
4. `Render`에 layout tree와 paint command 추가
5. `Host.WinForms`에서 최소 렌더 경로 연결
6. `Tests`로 작은 단위부터 고정

## 학습 원칙

- 책임을 분리한다.
- 파일/폴더 이름과 역할을 맞춘다.
- 과한 추상화보다 읽기 쉬운 구조를 우선한다.
- 각 단계가 빌드 가능하고 이해 가능한 상태를 유지한다.
