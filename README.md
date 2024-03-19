# unity_book_code_chapter3
> "가장 쉬운 유니티 게임 제작 2판"의 Chapter3 내용을 실습한 코드입니다.

## 목표 : 키보드, 마우스 입력에 따른 오브젝트 움직임 구현

- C\# 스크립트를 이용할 것이다.
- 기본 함수 `void  Start()`와 `void  Update()`가 이미 존재하며, 위치 갱신은 `Update()` 함수 내에서 할 것이다.
  - `void  Start()` 함수는 스크립트 실행 시 한 번만 실행한다.
  - `void  Update()` 함수는 매 프레임마다 반복해서 실행한다.
- `Start()` 함수에서 오브젝트의 위치 정보를 tr이라는 Transform 변수에 저장함.
  - `GetComponent<>()` 함수로 오브젝트의 component를 가져올 수 있다.
    - 꺽쇠 안에 Transform을 넣으면 위치 정보를 가져올 수 있다!
    - `Transform tr = GetComponent<Transform>();`
   
- `Update()` 함수에서 오브젝트의 위치 정보를 갱신함.
  - `tr.position = new Vector2(x, y);` 코드로 해당 오브젝트의 위치 정보를 (x, y)로 갱신할 수 있다.
  - 기존 tr의 정보에 적당한 값을 더해가며 위치 정보를 갱신하면 자연스러운 움직음을 구현할 수 있다.
 - 적당한 값을 `float  speed = 0.01f`라 하자.

### 키보드 입력에 따른 오브젝트 움직임 구현

- 키보드 화살표 입력에 따라 구현함.
- 두 가지 방법을 사용할 수 있다.
  1. 키보드 화살표 방향을 인식
  2. 키보드 입력이 좌우인지, 상하인지 하나로 묶어 인식
 
#### 1. 키보드 화살표 방향을 인식
  - if 조건문을 4개 만들어 누른 화살표를 인식한다.
    - `Input.GetKey(KeyCode.'Direct'Arrow)`에서 Direct 부분에 Right, Left, Up, Down을 넣어 4개의 조건문을 만든다.
  - 조건에 맞춰 speed를 x 혹은 y에 더하거나 뺀 값으로 위치 정보를 갱신한다.
    - `tr.position = new Vector2(x, y)`에서 `x = tr.posirion.x`, `y = tr.position.y`이다.
    - Right, Left에 따라 x에 +- speed, Up, Down에 따라 y에 +- speed를 해준다.
   
#### 2. 키보드 입력이 좌우인지, 상하인지 하나로 묶어 인식
  - `Input.GetAxis()` 함수를 이용하면 쉽게 할 수 있다.
  - `float x = Input.GetAxis("Horizontal") * speed;`를 하면 좌우 입력에 따라 x값이 조정된다.
    - 우측 화살표라면 speed에 곱해지는 값이 점점 커져 최대 1이 된다.
    - 좌측 화살표라면 speed에 곱해지는 값이 점점 작아져 최소 -1이 된다.
  - `float y = Input.GetAxis("Vertical") * speed;`를 하면 상하 입력에 따라 y값이 조정된다.
    - 상측 화살표라면 speed에 곱해지는 값이 점점 커져 최대 1이 된다.
    - 하측 화살표라면 speed에 곱해지는 값이 점점 작아져 최소 -1이 된다.
  - `tr.Translate(new Vector2(x, y));`로 위치를 조정한다.
    - `Translate()`는 내부 Vector의 값을 원래 값에 더해주는 함수다.
   
### 마우스 입력에 따른 오브젝트 움직임 구현

- `Input.GetMouseButton(0)`을 if문의 조건으로 걸어준다.
  - 마우스 클릭 여부를 확인하는 조건이다!
- `Vector2 mousePosition = Camera.main.ScreemToWorldPoint(Input.mousePosition);`으로 마우스 포인터가 클릭된 위치 정보를 받아온다.
- `tr.position = Vector2.MoveTowards(tr.position, mousePosition, Time.deltaTime * 5f);`로 오브젝트의 위치를 갱신한다.
  - `MoveTowards` 함수는 현재 위치, 목표 위치, 속도를 인자로 받는다. 현재 위치에서 마우스 포인터 위치로 일정 속도로 이동하게 된다.
    - Time.deltaTime은 이전 프레임에서 현재 프레임으로 넘어오는 시간이다.
    - 기기간 성능 차이 때문에 이 값을 곱해 최대한 기기간 이동 속도를 맞춰준다!
