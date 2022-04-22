Из-за двойных массивов в сгенерённом файле при дальнейшем использовании пакета выбрасывается System.PlatformNotSupportedException при попытке создать xml сериалайзер для fpml типа.
По этой причине в данном проекте отключена автогенерация. Вместо этого сейчас нужно скопировать в cmd и выполнить команду из command.cmd
Сформируется файл confirmation.cs

Далее ищем строчки типа:
[System.Xml.Serialization.XmlArrayItemAttribute("routingId", typeof(RoutingId), IsNullable=false)]
public RoutingId[][] routingIds {

и в атрибуте к typeof добавляем []. Т.е.
[System.Xml.Serialization.XmlArrayItemAttribute("routingId", typeof(RoutingId[]), IsNullable=false)]
public RoutingId[][] routingIds {

вот это править не надо(!):
[System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType="base64Binary")]
public byte[][] SPKISexp {