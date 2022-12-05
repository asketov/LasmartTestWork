
class PointsManager {
    constructor() {
        this.points = new Array();
    }
    loadPoints() {
       return $.getJSON('/point/getpoints/', (data) => {
            this.points = data;
        });
    }
    display() {
        var stage = new Konva.Stage({
            container: 'container',
            width: 0.7*window.innerWidth,
            height: 0.7*window.innerHeight
        });
        var layer = new Konva.Layer();
        for (var i = 0; i < this.points.length; i++) {
            var circle = new Konva.Circle({
                x: this.points[i].x,
                y: this.points[i].y,
                radius: this.points[i].radius,
                fill: this.points[i].color,
                padding: 40
            });
            for (var j = 0; j < this.points[i].comments.length; j++) {
                var comment = new Konva.Label({
                    x: this.points[i].x,
                    y: this.points[i].y + this.points[i].radius + 40 * (j + 1)
                });
                comment.add(
                new Konva.Tag({
                    fill: this.points[i].comments[j].backgroundColor,
                    stroke: '#555',
                    strokeWidth: 5
                }));
                comment.add(
                    new Konva.Text({
                        text: this.points[i].comments[j].text,
                        fontFamily: 'Calibri',
                        fontSize: 18,
                        padding: 5,
                        fill: 'green',
                        })
                );
                comment.offsetX(comment.width() / 2);
                layer.add(circle).add(comment); 
            }
            stage.add(layer);
            layer.draw();
        }
    }
    findPoint(x, y) { 
       return this.points.find(point =>
            x <= (point.x + point.radius) && x >= (point.x - point.radius)
                && y <= (point.y + point.radius) && y >= (point.y - point.radius));
    }
    deletePoint(point) {
        this.points = this.points.filter(p => p.id != point.id);
        return $.ajax({
            type: "DELETE",
            url: "/point/deletepoint/?id=" + point.id,
        });
    }
}

