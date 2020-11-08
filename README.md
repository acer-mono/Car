# Car
### Функциональные требования
Автомобиль представлен композицией деталей и узлов. Каждая деталь имеет собственный вес.
Каждый узел состоит из нескольких деталей и тоже характеризуется совокупным весом.
<table>
    <tr>
        <th>Assembly/Unit</th>
        <th>Name</th>
        <th>Quantity</th>
        <th>* Weight</th>
    </tr>
    <tr>
        <td>Car</td>
        <td>Engine V6</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Wheel</td>
        <td>4</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Transmission</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Differential</td>
        <td>2</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Door</td>
        <td>4</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Gas tank</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td>Engine V6</td>
        <td>Piston system</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Valve system</td>
        <td>1</td>
        <td></td>
    </tr>
     <tr>
        <td></td>
        <td>intake manifold</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>exhaust manifold</td>
        <td>2</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Radiator</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td>Piston system</td>
        <td>Piston</td>
        <td>4</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Crankshaft</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Link</td>
        <td>4</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Gasket</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td>Value system</td>
        <td>Value</td>
        <td>24</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Camshaft</td>
        <td>2</td>
        <td></td>
    </tr>
    <tr>
        <td>Wheel</td>
        <td>Disk</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>Tire</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td>Door</td>
        <td>Glass</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>door card</td>
        <td>1</td>
        <td></td>
    </tr>
    <tr>
        <td>Differential</td>
        <td>gears</td>
        <td>5</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>bearing</td>
        <td>3</td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>shank</td>
        <td>1</td>
        <td></td>
    </tr>
</table>

Реализовать решение, позволяющее клиенту (Plant) подсчитать конечный вес собранного
автомобиля и вывести детализированную информацию о кол-ве деталей, их вес, состав узлов и их
вес и общий вес автомобиля. * Вес узлов/деталей задайте самостоятельно.

### Нефункциональные требования:
1. Платформа: Консольное приложение для OS Windows.
2. Язык реализации: C# / Java / C++.
3. Вызов каждого метода должен сопровождаться простым выводом в консоль информации
   о действии метода/его результат.
4. Структура проекта должна включать каталоги для размещения классов, интерфейсов и
   абстрактных классов с именованием согласно предметной области.

### Реализация
#### Ввод
Не подразумевает передачу аргументов.

#### Вывод 
Выводится детализированная информация об устройстве машины.

Пример:

```
Name: Car
Quantity: 1
Weight: 433

        Name: Engine
        Quantity: 1
        Weight: 184
        _
                Name: Piston system
                Quantity: 1
                Weight: 27
                __
                        Name: Piston
                        Quantity: 4
                        Weight: 4
                        ___
                        Name: Crankshaft
                        Quantity: 1
                        Weight: 2
                        ___
                        Name: Link
                        Quantity: 4
                        Weight: 16
                        ___
                        Name: Gasket
                        Quantity: 1
                        Weight: 5
                        ___
                Name: Valve system
                Quantity: 1
                Weight: 148
                __
                        Name: Value
                        Quantity: 24
                        Weight: 144
                        ___
                        Name: Camshaft
                        Quantity: 2
                        Weight: 4
                        ___
                Name: intake manifold
                Quantity: 1
                Weight: 2
                __
                Name: exhaust manifold
                Quantity: 2
                Weight: 4
                __
                Name: Radiator
                Quantity: 1
                Weight: 3
                __
        Name: Wheel
        Quantity: 4
        Weight: 92
        _
                Name: Disk
                Quantity: 1
                Weight: 11
                __
                Name: Tire
                Quantity: 1
                Weight: 12
                __
        Name: Transmission
        Quantity: 1
        Weight: 10
        _
        Name: Differential
        Quantity: 2
        Weight: 100
        _
                Name: gears
                Quantity: 5
                Weight: 5
                __
                Name: bearing
                Quantity: 3
                Weight: 33
                __
                Name: shank
                Quantity: 1
                Weight: 12
                __
        Name: Door
        Quantity: 4
        Weight: 44
        _
                Name: Glass
                Quantity: 1
                Weight: 9
                __
                Name: door card
                Quantity: 1
                Weight: 2
                __
        Name: Gas tank
        Quantity: 1
        Weight: 3
        _

```