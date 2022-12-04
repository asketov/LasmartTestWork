import { IRect, RGB, RGBA, Vector2d } from './types';
export declare class Transform {
    m: Array<number>;
    dirty: boolean;
    constructor(m?: number[]);
    reset(): void;
    copy(): Transform;
    copyInto(tr: Transform): void;
    point(point: Vector2d): {
        x: number;
        y: number;
    };
    translate(x: number, y: number): this;
    scale(sx: number, sy: number): this;
    rotate(rad: number): this;
    getTranslation(): {
        x: number;
        y: number;
    };
    skew(sx: number, sy: number): this;
    multiply(matrix: Transform): this;
    invert(): this;
    getMatrix(): number[];
    decompose(): {
        x: number;
        y: number;
        rotation: number;
        scaleX: number;
        scaleY: number;
        skewX: number;
        skewY: number;
    };
}
export declare const Util: {
    _isElement(obj: any): obj is Element;
    _isFunction(obj: any): boolean;
    _isPlainObject(obj: any): boolean;
    _isArray(obj: any): obj is any[];
    _isNumber(obj: any): obj is number;
    _isString(obj: any): obj is string;
    _isBoolean(obj: any): obj is boolean;
    isObject(val: any): val is Object;
    isValidSelector(selector: any): boolean;
    _sign(number: number): 1 | -1;
    requestAnimFrame(callback: Function): void;
    createCanvasElement(): HTMLCanvasElement;
    createImageElement(): HTMLImageElement;
    _isInDocument(el: any): boolean;
    _urlToImage(url: string, callback: Function): void;
    _rgbToHex(r: number, g: number, b: number): string;
    _hexToRgb(hex: string): RGB;
    getRandomColor(): string;
    getRGB(color: string): RGB;
    colorToRGBA(str: string): RGBA;
    _namedColorToRBA(str: string): {
        r: any;
        g: any;
        b: any;
        a: number;
    };
    _rgbColorToRGBA(str: string): RGBA;
    _rgbaColorToRGBA(str: string): RGBA;
    _hex6ColorToRGBA(str: string): RGBA;
    _hex3ColorToRGBA(str: string): RGBA;
    _hslColorToRGBA(str: string): RGBA;
    haveIntersection(r1: IRect, r2: IRect): boolean;
    cloneObject<Any>(obj: Any): Any;
    cloneArray(arr: Array<any>): any[];
    degToRad(deg: number): number;
    radToDeg(rad: number): number;
    _degToRad(deg: number): number;
    _radToDeg(rad: number): number;
    _getRotation(radians: any): any;
    _capitalize(str: string): string;
    throw(str: string): never;
    error(str: string): void;
    warn(str: string): void;
    each(obj: any, func: any): void;
    _inRange(val: any, left: any, right: any): boolean;
    _getProjectionToSegment(x1: any, y1: any, x2: any, y2: any, x3: any, y3: any): any[];
    _getProjectionToLine(pt: Vector2d, line: any, isClosed: any): Vector2d;
    _prepareArrayForTween(startArray: any, endArray: any, isClosed: any): any[];
    _prepareToStringify(obj: any): any;
    _assign<T, U>(target: T, source: U): T & U;
    _getFirstPointerId(evt: any): any;
    releaseCanvas(...canvases: HTMLCanvasElement[]): void;
};
