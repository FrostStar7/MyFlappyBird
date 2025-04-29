* `Input.GetMouseButton(0)`//0是鼠标左键，1是鼠标右键。检测到则返回true        `Input.GetMouseButtonDown(0)`//鼠标松开后则停止检测，即只检测一次点击。 

* `Rigidbody2D rb2d = GetComponent<Rigidbody2D>()`;//获取挂载该脚本的游戏对象所挂载的其他组件 。！！可在Unity中拖拽赋值代替。

  `rb2d.velocity = new Vector2(0,8);`//新赋值需与对象类型对应。

* `transform.Translate(-0.5f,0,0)`//相对位置变化，(x坐标相对原坐标-0.5)