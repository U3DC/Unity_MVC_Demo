# Unity_MVC_Demo
MVC 模式代表 Model-View-Controller（模型-视图-控制器） 模式。这种模式用于应用程序的分层开发。

Model（模型） - 模型代表一个存取数据的对象。它也可以带有逻辑，在数据变化时更新控制器。

View（视图） - 视图代表模型包含的数据的可视化，在unity中，可以理解为你看到的对象，比如一个文本UI元素。

Controller（控制器） - 控制器作用于模型和视图上。它控制数据流向模型对象，并在数据变化时更新视图。它使视图与模型分离开。

实现：

- 我们将创建一个作为模型的 PlayerModel 数据模型对象。PlayerView 是一个把玩家信息输出到控制台的视图类，PlayerController 是负责存储数据到 PlayerModel 对象中的控制器类，并相应地更新视图 PlayerView。

- 此Demo演示MVC模式的用法。
