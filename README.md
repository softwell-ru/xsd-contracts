Из-за двойных массивов в сгенерённом файле при дальнейшем использовании пакета выбрасывается System.PlatformNotSupportedException при попытке создать xml сериалайзер для fpml типа.
Чтобы сгенерить по схеме код надо выполнить пипилину вручную и указать перемешку generate=1
Сформируются файлы %имя_схемы%.cs


Я не уверен, надо ли это делать для чего-то кроме fpml.confirmation и fpml.pretrade, но возможно.


Далее ищем строчки типа:
[System.Xml.Serialization.XmlArrayItemAttribute("routingId", typeof(RoutingId), IsNullable=false)]
public RoutingId[][] routingIds {

и в атрибуте к typeof добавляем []. Т.е.
[System.Xml.Serialization.XmlArrayItemAttribute("routingId", typeof(RoutingId[]), IsNullable=false)]
public RoutingId[][] routingIds {

вот это править не надо(!):
[System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType="base64Binary")]
public byte[][] SPKISexp {